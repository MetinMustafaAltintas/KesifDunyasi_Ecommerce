using Project.COREMVC.Models.Orders.PureVMs;
using Project.COREMVC.Models.OuterRequestModels;

namespace Project.COREMVC.Models.Orders.PageVMs
{
    public class CreateOrderPageVM
    {
        public PaymentRequestModel PaymentRequestModel { get; set; }
        public LoginCreateOrderPureVM LoginCreate { get; set; }
        public NoLoginCreateOrderPureVM NoLoginCreate { get; set; }
    }
}
