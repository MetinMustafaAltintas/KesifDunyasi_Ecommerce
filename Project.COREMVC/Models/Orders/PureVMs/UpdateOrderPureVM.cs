using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.Orders.PureVMs
{
    public class UpdateOrderPureVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [EmailAddress(ErrorMessage = "Email formatında giriş yapınız")]
        public string Email { get; set; }
    }
}
