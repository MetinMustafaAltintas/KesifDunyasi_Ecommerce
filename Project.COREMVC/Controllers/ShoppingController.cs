using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Models.Orders;
using Project.COREMVC.Models.PageVms;
using Project.COREMVC.Models.SessionService;
using Project.COREMVC.Models.ShoppingTools;
using Project.ENTITIES.Models;
using System.Text;
using X.PagedList;

namespace Project.COREMVC.Controllers
{
    public class ShoppingController : Controller
    {
        readonly IProductManager _productManager;
        readonly ICategoryManager _categoryManager;
        readonly IOrderManager _orderManager;
        readonly IOrderDetailManager _orderDetailManager;
        readonly UserManager<AppUser> _userManager;
        readonly IHttpClientFactory _httpClientFactory;



        public ShoppingController(IOrderManager orderManager, IOrderDetailManager orderDetailManager,IProductManager productManager,ICategoryManager categoryManager, UserManager<AppUser> userManager, IHttpClientFactory httpClientFactory)
        {
            _orderManager = orderManager;
            _orderDetailManager = orderDetailManager;
            _productManager = productManager;
            _categoryManager = categoryManager;
            _userManager = userManager;
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index(int? page, int? categoryID)
        {
            //string a = "Cagri";

            //string b = a ?? "Deneme";

            ShoppingPageVM spVm = new()
            {
                Products = categoryID == null ? _productManager.GetActives().ToPagedList(page ?? 1, 5) : _productManager.Where(x => x.CategoryID == categoryID).ToPagedList(page ?? 1, 5),
                Categories = _categoryManager.GetActives()
            };

            if (categoryID != null) TempData["catID"] = categoryID;

            return View(spVm);
        }
        public async Task<IActionResult> AddToCart(int id)
        {
            Cart c = GetCartFromSession("scart") == null ? new Cart() : GetCartFromSession("scart");
            Product productToBeAdded = await _productManager.FindAsync(id);
            CartItem ci = new()
            {
                ID = productToBeAdded.ID,
                ProductName = productToBeAdded.ProductName,
                UnitPrice = productToBeAdded.UnitPrice,
                ImagePath = productToBeAdded.ImagePath,
                CategoryName = productToBeAdded.Category.CategoryName,
                CategoryID = productToBeAdded.CategoryID
            };

            c.AddToCart(ci);

            SetCartForSession(c);

            TempData["Message"] = $"{ci.ProductName} isimli ürün sepete eklenmiştir";

            return RedirectToAction("Index");

        }

        void SetCartForSession(Cart c)
        {
            HttpContext.Session.SetObject("scart", c);
        }

        Cart GetCartFromSession(string key)
        {
            return HttpContext.Session.GetObject<Cart>(key);
        }

        public IActionResult CartPage()
        {
            if (GetCartFromSession("scart") == null)
            {
                TempData["Message"] = "Sepetiniz su anda bos";
                return RedirectToAction("Index");
            }

            Cart c = GetCartFromSession("scart");
            return View(c); //Todo : PageVM refactoring'i yapmayı unutmayın...
        }

        public IActionResult DeleteFromCart(int id)
        {
            if (GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.RemoveFromCart(id);
                SetCartForSession(c);
                ControlCart(c);
            }
            return RedirectToAction("CartPage");
        }

       

        void ControlCart(Cart c)
        {
            if (c.GetCartItems.Count == 0) HttpContext.Session.Remove("scart");
        }

        public IActionResult DecreaseFromCart(int id)
        {

            if (GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.Decrease(id);
                SetCartForSession(c);
                ControlCart(c);
            }

            return RedirectToAction("CartPage");
        }

        public IActionResult ConfirmOrder()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ConfirmOrder(OrderRequestPageVM ovm)
        {
            Cart c = GetCartFromSession("scart");
            ovm.Order.PriceOfOrder = ovm.PaymentRequestModel.ShoppingPrice = c.TotalPrice;
            
            //http://localhost:5053/
            //API Entegrasyonu 
            #region APIIntegration

            HttpClient client = _httpClientFactory.CreateClient();
            string jsonData = JsonConvert.SerializeObject(ovm.PaymentRequestModel);

            //Content : Icerik
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:5053/api/Transaction", content);  

            if (responseMessage.IsSuccessStatusCode)
            {
                if (User.Identity.IsAuthenticated)
                {
                    AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                    ovm.Order.AppUserID = appUser.Id; //Normalde Order'in icerisindeki Email ve NameDescription null gecilebilir olması gereken şeylerdir...Cünkü AppUserId zaten sistemdedir ve Order'in Email'ine gerek yoktur...Lakin bu durumda üye olmayan da  alısveriş yapabilsin diye bu noktada onları Required olarak tanımlamak gerekir (Pure VM'de)
                    ovm.Order.Email = appUser.Email; //Normalde bunların böyle verilmesine gerek yok string property'i nullable yapabilirdik(.Net 6'da artık referans tiplere özellikle null gecilebilir demezseniz veritabanına not nullable olarak gidiyor). Ancak Entities'in düzenini tekrar bozmamak adına böyle bir yöntemi tercih ettik...
                    ovm.Order.NameDescription = appUser.UserName;
                }

                await _orderManager.AddAsync(ovm.Order); //Önce Order'in ID'sinin olusması lazım... Burada Order'i kaydederek o ID'nin Identity sayesinde olusmasını saglıyoruz...

                //string urunIsimleri = null;
                foreach (CartItem item in c.GetCartItems)
                {
                    OrderDetail od = new();
                    od.OrderID = ovm.Order.ID;
                    od.ProductID = item.ID;
                    od.Quantity = item.Amount;
                    od.UnitPrice = item.UnitPrice;
                    await _orderDetailManager.AddAsync(od);
                    //urunIsimleri += item.ProductName;
                }

                TempData["Message"] = "Siparişiniz bize basarıyla ulasmıstır...Teşekkür ederiz";
                return RedirectToAction("Index");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();
            TempData["Message"] = result;
            return RedirectToAction("Index");




            #endregion



        }
    }
}
