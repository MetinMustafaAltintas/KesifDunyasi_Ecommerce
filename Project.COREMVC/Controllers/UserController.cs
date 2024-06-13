using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.COMMON.Tools;
using Project.COREMVC.Models.Profile.PageVMs;
using Project.COREMVC.Models.User.PageVMs;
using Project.COREMVC.Models.User.PureVMs;
using Project.ENTITIES.Models;
using System;

namespace Project.COREMVC.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class UserController : Controller
    {
        readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult UpdatePassword(int id)
        {
            UpdatePasswordPureVM passwordPureVM = new UpdatePasswordPureVM();
            passwordPureVM.ID = id;
            UpdatePasswordPageVM pageVM = new UpdatePasswordPageVM();
            pageVM.UpdatePasswordPureVM = passwordPureVM;
            return View(pageVM);
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePassword(UpdatePasswordPageVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByIdAsync(model.UpdatePasswordPureVM.ID.ToString());
                IdentityResult result = await _userManager.ChangePasswordAsync(appUser, model.UpdatePasswordPureVM.CurrentPassword, model.UpdatePasswordPureVM.NewPassword);

                if (result.Succeeded)
                {
                    TempData["Message"] = "Şifreniz Güncelledi";
                    return RedirectToAction("Index", "Profile", new { name = appUser.UserName });
                }
                else
                {
                    TempData["Message"] = "Hata!! Şifre Güncellenemedi";
                    return View(model);
                }
            }
            return View(model);
        }

        public IActionResult ChangeEmail()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangeEmail(ChangeEmailPageVM model)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(model.ChangeEmailPureVM.CurrentEmail);

            if (appUser == null)
            {
                TempData["Message"] = "Bu Mailde Kullanıcı Bulunamadı";
                return View(model);
            }
            else
            {
                Guid specId = Guid.NewGuid();
                appUser.ActivationCode = specId;
                IdentityResult result = await _userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                {
                    string body = $"Hesabınızın Mail Adresini onaylamak için  http://localhost:5014/User/ConfirmEmailChange?email={model.ChangeEmailPureVM.NewEmail}&specId={specId}&id={appUser.Id} linkine tıklayınız";

                    MailService.Send(model.ChangeEmailPureVM.NewEmail, body: body);
                    TempData["Message"] = "Onay için Mail Gitmiştir";
                    return RedirectToAction("Index", "Profile", new { name = appUser.UserName });
                }
                TempData["Message"] = "Maalesef Hata ile Karşılandı";
                return View(model);
            }
        }
        public async Task<IActionResult> ConfirmEmailChange(string email ,Guid specId, int id)
        {
            AppUser user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                TempData["Message"] = "Kullanıcı bulunamadı";
                return RedirectToAction("Index", "Signin");
            }
            else if (user.ActivationCode == specId)
            {
                await _userManager.SetEmailAsync(user, email);
                TempData["Message"] = "Emailiniz basarıyla güncellendi";
                return RedirectToAction("Index", "Signin");

            }
            TempData["Message"] = "Maalesef Hata ile Karşılandı";
            return RedirectToAction("Index", "Signin");
        }
    }
}