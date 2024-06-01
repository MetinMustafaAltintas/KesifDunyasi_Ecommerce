using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.ViewModels.AppUsers.PureVms
{
    public class UserRegisterRequestModel
    {
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [Display(Name = "Kullanıcı Ismi")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Email Formatında Giriş Yapınız")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [MinLength(8, ErrorMessage = "Minimum {0} 8 karakter girilmesi gereklidir")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$", ErrorMessage = "Şifreniz en az 8 karakter uzunluğunda olmalı ve en az bir büyük harf, bir küçük harf, bir sayı ve bir özel karakter içermelidir.")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
