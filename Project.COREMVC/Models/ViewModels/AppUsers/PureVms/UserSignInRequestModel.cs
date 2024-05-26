using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.ViewModels.AppUsers.PureVms
{
    public class UserSignInRequestModel
    {
        [Required(ErrorMessage = "Kullanıcı ismi zorunludur")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Sifre alanı zorunludur")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string? ReturnUrl { get; set; } //Burası kişinin baslangıcta gitmek istedigi adresi tutar...Kişi eger login olmadan bir adrese gitmeye calısırsa ve o adres Authorization'a sahipse kişi engellenir ve Login'e atılır...Login'den istenilen role sahip oldugunu kanıtlarsa tekrar ilk gitmek istedigi adrese otomatik gönderilmesi daha iyi olur...
    }
}
