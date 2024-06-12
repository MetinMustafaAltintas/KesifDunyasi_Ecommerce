using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Areas.Admin.Models.User.PureVMs
{
    public class CreateUserRequestModel
    {
        [Required(ErrorMessage = "Kullanıcı ismi alanı girilmesi zorunludur")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [EmailAddress(ErrorMessage = "Email formatında giriş yapınız")]
        public string Email { get; set; }

    }
}
