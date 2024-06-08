using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Areas.Admin.Models.OrderDetail.PageVMs;
using Project.COREMVC.Areas.Admin.Models.OrderDetail.PureVMs;
using Project.COREMVC.Models.OrderDetail.PageVMs;
using Project.COREMVC.Models.OrderDetail.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderDetailController : Controller
    {
        readonly IOrderDetailManager _orderDetailManager;
        public OrderDetailController(IOrderDetailManager orderDetailManager)
        {
            _orderDetailManager = orderDetailManager;
        }

        public IActionResult OrderDetail(int id)
        {
            List<OrderDetail> orderDetails = _orderDetailManager.Where(x => x.OrderID == id);

            List<OrderDetailPureVM> detailPureVMs = orderDetails.Select(detailPureVMs => new OrderDetailPureVM
            {
                ProductName = detailPureVMs.Product.ProductName,
                Quantity = detailPureVMs.Quantity,
                UnitPrice = detailPureVMs.UnitPrice,
            }).ToList();

            OrderDetailPageVM detailPageVM = new OrderDetailPageVM();
            detailPageVM.OrderDetailPureVMs = detailPureVMs;
            return View(detailPageVM);
        }
    }
}
