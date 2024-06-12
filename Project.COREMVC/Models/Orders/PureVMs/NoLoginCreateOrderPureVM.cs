using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.Orders.PureVMs
{
    public class NoLoginCreateOrderPureVM
    {
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        public string ShippingAddress { get; set; }
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [EmailAddress(ErrorMessage = "Email formatında giriş yapınız")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        public string NameDescription { get; set; } 
    }
}
