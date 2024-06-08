using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Models.OrderDetail.PageVMs;
using Project.COREMVC.Models.OrderDetail.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Controllers
{
    public class OrderDetailController : Controller
    {
        readonly IOrderDetailManager _orderDetailManager;
        public OrderDetailController(IOrderDetailManager orderDetailManager)
        {
            _orderDetailManager = orderDetailManager;
        }

        public async Task<IActionResult> Index(int id)
        {
            List<OrderDetail> orderDetails = _orderDetailManager.Where(x => x.OrderID == id);

            List<GetOrderDetailPureVM> getOrders = orderDetails.Select(getOrders => new GetOrderDetailPureVM
            {
                ProductName = getOrders.Product.ProductName,
                Quantity = getOrders.Quantity,
                UnitPrice = getOrders.UnitPrice,
            }).ToList();

            GetOrderDetailPageVM detailPageVM = new GetOrderDetailPageVM();
            detailPageVM.GetOrderDetailPureVMs = getOrders;
            return View(detailPageVM);
        }

        
    }
}
