using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Areas.Admin.Models.Order.PageVMs;
using Project.COREMVC.Areas.Admin.Models.Order.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        readonly IOrderManager _orderManager;
        public OrderController(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public IActionResult Index()
        {
            List<Order> orders = _orderManager.GetAll();

            List<GetOrderPureVM> orderPureVMs = orders.Select(o => new GetOrderPureVM
            {
                ID = o.ID,
                ShippingAddress = o.ShippingAddress,
                Email = o.Email,
                NameDescription = o.NameDescription,
                PriceOfOrder = o.PriceOfOrder,
                AppUserID = o.AppUserID,
                Shipper = o.Shipper.CompanyName,
                Status = o.Status
            }).ToList();

            GetOrderPageVM orderPageVM = new GetOrderPageVM();
            orderPageVM.GetOrderPureVMs = orderPureVMs;
            return View(orderPageVM);
        }
    }
}
