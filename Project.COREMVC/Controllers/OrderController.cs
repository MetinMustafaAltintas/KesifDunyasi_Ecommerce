using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Models.Orders.PageVMs;
using Project.COREMVC.Models.Orders.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Controllers
{
    public class OrderController : Controller
    {
        readonly IOrderManager _orderManager;
        readonly IOrderDetailManager _orderDetailManager;
        readonly UserManager<AppUser> _userManager;
        public OrderController(IOrderManager orderManager, IOrderDetailManager orderDetailManager, UserManager<AppUser> userManager)
        {
            _orderManager = orderManager;
            _orderDetailManager = orderDetailManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string name)
        {
            AppUser appUser = await _userManager.FindByNameAsync(name);

            List<Order> orders =  _orderManager.Where(x => x.AppUserID == appUser.Id);

            List<ListOrderPureVM> orderPureVMs = orders.Select(orderPureVMs => new ListOrderPureVM
            {
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
    }
}
