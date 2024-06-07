using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.User.PureVMs
{
    public class ChangeEmailPureVM
    {
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [EmailAddress(ErrorMessage = "Email formatında giriş yapınız")]
        public string CurrentEmail { get; set; }
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [EmailAddress(ErrorMessage = "Email formatında giriş yapınız")]
        public string NewEmail { get; set; }
    }
}
