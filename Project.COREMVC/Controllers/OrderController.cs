using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.BLL.Managers.Concretes;
using Project.COREMVC.Models.Orders.PageVMs;
using Project.COREMVC.Models.Orders.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Controllers
{
    public class OrderController : Controller
    {
        readonly IOrderManager _orderManager;
        readonly UserManager<AppUser> _userManager;
        public OrderController(IOrderManager orderManager , UserManager<AppUser> userManager)
        {
            _orderManager = orderManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string name)
        {
            AppUser appUser = await _userManager.FindByNameAsync(name);

            List<Order> orders =  _orderManager.Where(x => x.AppUserID == appUser.Id);
            if (orders.Count == 0)
            {
                TempData["Message"] = "Daha Önce Siparis Vermediniz";
                return RedirectToAction("Index","Shopping");
            }

            List<ListOrderPureVM> orderPureVMs = orders.Select(orderPureVMs => new ListOrderPureVM
            {
                ID =orderPureVMs.ID,
                IsimSoyisim = orderPureVMs.NameDescription,
                Email = orderPureVMs.Email,
                SiparisTutari = orderPureVMs.PriceOfOrder,
                Adres = orderPureVMs.ShippingAddress,
                KargoFirmasi = orderPureVMs.Shipper.CompanyName
            }).ToList();
            
            ListOrderPageVM listOrderPageVM = new ListOrderPageVM();
            listOrderPageVM.ListOrderPureVMs = orderPureVMs;
            return View(listOrderPageVM);
        }

        public async Task<IActionResult> OrderChangeMail(int id)
        {
            Order order = await _orderManager.FindAsync(id);
            UpdateOrderPureVM updateOrder = new UpdateOrderPureVM();
            updateOrder.ID = order.ID;
            UpdateOrderPageVM updateOrderPage = new UpdateOrderPageVM();
            updateOrderPage.UpdateOrderPureVM = updateOrder;
            return View(updateOrderPage);
        }
        [HttpPost]
        public async Task<IActionResult> OrderChangeMail(UpdateOrderPageVM model)
        {
            Order order = await _orderManager.FindAsync(model.UpdateOrderPureVM.ID);
            order.Email = model.UpdateOrderPureVM.Email;
            _orderManager.UpdateAsync(order);
            TempData["Message"] = "Siparişiniz Güncellendi";
            return RedirectToAction("Index", "Shopping");
        }


    }
}
