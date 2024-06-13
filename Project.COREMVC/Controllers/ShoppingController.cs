using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.BLL.Managers.Abstracts;
using Project.COMMON.Models;
using Project.COMMON.Tools;
using Project.COREMVC.Models.Orders.PageVMs;
using Project.COREMVC.Models.SessionService;
using Project.COREMVC.Models.Shopping.PageVMs;
using Project.COREMVC.Models.Shopping.PureVMs;
using Project.COREMVC.Models.ShoppingTools;
using Project.ENTITIES.Models;
using System.Text;
using X.PagedList;

namespace Project.COREMVC.Controllers
{
    [AutoValidateAntiforgeryToken]
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
            IPagedList<Product> products = _productManager.GetActives().ToPagedList();

            IPagedList<ProductPureVM> productsPure = products.Select(productsPure => new ProductPureVM
            {
                ID = productsPure.ID,
                ProductName = productsPure.ProductName,
                UnitPrice = productsPure.UnitPrice,
                ImagePath = productsPure.ImagePath,
                CategoryID = productsPure.CategoryID.Value,
                CategoryName = productsPure.Category.CategoryName,
            }).ToPagedList();
            List<Category> categories = _categoryManager.GetActives();

            List<CategoryPureVM> categoryPures = categories.Select(categoryPures => new CategoryPureVM
            {
                ID = categoryPures.ID,
                CategoryName = categoryPures.CategoryName
            }).ToList();

            ShoppingPageVM spVm = new()
            {
                ProductPureVMs = categoryID == null ? productsPure.ToPagedList(page ?? 1, 5) : productsPure.Where(x => x.CategoryID == categoryID).ToPagedList(page ?? 1, 5),
               CategoryPureVMs = categoryPures
            };

            if (categoryID != null) TempData["catID"] = categoryID;
            return View(spVm);
        }
        public async Task<IActionResult> AddToCart(int id , string returnUrl)
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
            return Redirect(returnUrl);
          //  return RedirectToAction("Index");
           

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
            MyCartPageVM myCartPageVM = new MyCartPageVM();
            myCartPageVM.CartItems = c.GetCartItems;
            return View(myCartPageVM); 
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
        public IActionResult DeleteCart()
        {
            if (GetCartFromSession("scart") != null)
            {
                HttpContext.Session.Remove("scart");
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
        public async Task<IActionResult> ConfirmOrder(CreateOrderPageVM model)
        {
            Cart c = GetCartFromSession("scart");
            model.PaymentRequestModel.ShoppingPrice = c.TotalPrice;
            
            //http://localhost:5053/
            //API Entegrasyonu 
            #region APIIntegration

            HttpClient client = _httpClientFactory.CreateClient();
            string jsonData = JsonConvert.SerializeObject(model.PaymentRequestModel);

            //Content : Icerik
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:5053/api/Transaction", content);  

            if (responseMessage.IsSuccessStatusCode)
            {
                Order order = new Order();
                if (User.Identity.IsAuthenticated)
                {
                    AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                    
                    order.ShippingAddress = model.LoginCreate.ShippingAddress;
                    order.AppUserID = appUser.Id;
                    order.Email = appUser.Email;
                    order.NameDescription = $"{appUser.Profile.FirstName} {appUser.Profile.LastName}";
                }
                else
                {
                    order.ShippingAddress= model.NoLoginCreate.ShippingAddress;
                    order.Email= model.NoLoginCreate.Email;
                    order.NameDescription= model.NoLoginCreate.NameDescription;
                }
                order.ShipperID = 1;
                order.PriceOfOrder = c.TotalPrice;
                await _orderManager.AddAsync(order); //Önce Order'in ID'sinin olusması lazım... Burada Order'i kaydederek o ID'nin Identity sayesinde olusmasını saglıyoruz...
                List<OrderedProducts> orderedProducts = new List<OrderedProducts>();
                
                foreach (CartItem item in c.GetCartItems)
                {
                    OrderDetail od = new();
                    od.OrderID = order.ID;
                    od.ProductID = item.ID;
                    od.Quantity = item.Amount;
                    od.UnitPrice = item.UnitPrice;
                    await _orderDetailManager.AddAsync(od);

                    OrderedProducts orderedProduct = new OrderedProducts();
                    orderedProduct.Name = item.ProductName;
                    orderedProduct.Price = item.UnitPrice;
                    orderedProduct.Quantity = item.Amount;
                    orderedProducts.Add(orderedProduct);
                }

                MailService.MailOrder(order.Email, orderedProducts);
                DeleteCart();
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
