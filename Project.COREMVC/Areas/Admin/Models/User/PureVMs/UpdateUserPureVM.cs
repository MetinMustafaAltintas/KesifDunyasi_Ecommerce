using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Areas.Admin.Models.User.PureVMs
{
    public class UpdateUserPureVM
    {
        public string id { get; set; }
        [Required(ErrorMessage = "Email girilmesi zorunludur")]
        [EmailAddress(ErrorMessage = "Email formatında giriş yapınız")]
        public string Email { get; set; }

    }
}
