using Project.COREMVC.Models.ViewModels.AppUsers.PureVms;
using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.ViewModels.AppUsers.PageVms
{
    public class UserSignInPageVM
    {
        public UserSignInRequestModel UserSignInRequestModel { get; set; }
        [EmailAddress(ErrorMessage = "Email Formatında Giriş Yapınız")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
