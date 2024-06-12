using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.Orders.PureVMs
{
    public class LoginCreateOrderPureVM
    {
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        public string ShippingAddress { get; set; } 
    }
}
