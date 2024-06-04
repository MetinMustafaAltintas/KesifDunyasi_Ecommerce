using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using NuGet.Common;
using Project.BLL.Managers.Abstracts;
using Project.COMMON.Tools;
using Project.COREMVC.Areas.Admin.Models.User.PureVMs;
using Project.COREMVC.Models;
using Project.COREMVC.Models.AppUsers;
using Project.COREMVC.Models.ViewModels.AppUsers.PageVms;
using Project.COREMVC.Models.ViewModels.AppUsers.PureVms;
using Project.ENTITIES.Models;
using System.Diagnostics;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;


namespace Project.COREMVC.Controllers
{
    [AutoValidateAntiforgeryToken] //Get ile gelen sayfada verilen özel bir token sayesinde Post'un bu tokensiz yapýlamamasýný saglar...PostMan gibi third part software'lerinden gözlemlediginizde direkt Post tarafýna ulasamadýgýnýzý göreceksiniz...
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly UserManager<AppUser> _userManager;
        readonly RoleManager<AppRole> _roleManager;
        readonly SignInManager<AppUser> _signInManager;
        readonly IProfileManager _profile;

        public HomeController(ILogger<HomeController> logger , UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IProfileManager profile)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _profile = profile;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequestModel model)
        {
            if (ModelState.IsValid)
            {
                //Cagri: Automapper
                Guid specId = Guid.NewGuid();
                AppUser appUser = new()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    ActivationCode = specId
                };

                IdentityResult result = await _userManager.CreateAsync(appUser, model.Password);

                if (result.Succeeded)
                {
                    #region RolKontrolIslemleri
                    AppRole appRole = await _roleManager.FindByNameAsync("Member");
                    if (appRole == null) await _roleManager.CreateAsync(new() { Name = "Member" });
                    await _userManager.AddToRoleAsync(appUser, "Member");
                    #endregion


                    string body = $"Hesabýnýz olusturulmustur...Üyeligini onaylamak icin lütfen http://localhost:5014/Home/ConfirmEmail?specId={specId}&id={appUser.Id} linkine týklayýnýz";

                    MailService.Send(model.Email, body: body);
                    TempData["Message"] = "Mailinizi kontrol ediniz";
                    return RedirectToAction("RedirectPanel");

                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }


            }
            return View(model);
        }

        public async Task<IActionResult> ConfirmEmail(Guid specId, int id)
        {
            AppUser user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                TempData["Message"] = "Kullanýcý bulunamadý";
                return RedirectToAction("RedirectPanel");
            }
            else if (user.ActivationCode == specId)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                TempData["Message"] = "Emailiniz basarýyla onaylandý";
                return RedirectToAction("SignIn");

            }
            return RedirectToAction("Register");
        }

        public IActionResult RedirectPanel()
        {
            return View();
        }

        public IActionResult SignIn(string returnUrl)
        {
            UserSignInRequestModel usModel = new()
            {
                ReturnUrl = returnUrl
            };

            UserSignInPageVM usPageVM = new()
            {
                 UserSignInRequestModel = usModel
            };
            return View(usPageVM);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInRequestModel UserSignInRequestModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser appUser = await _userManager.FindByNameAsync(UserSignInRequestModel.UserName);

                    AppUserProfile appUserProfile = await _profile.FindAsync(appUser.Id);
                    SignInResult result = await _signInManager.PasswordSignInAsync(appUser, UserSignInRequestModel.Password, UserSignInRequestModel.RememberMe, true);
                    if (result.Succeeded)
                    {
                        if (appUserProfile == null)
                        {
                            return RedirectToAction("CreateProfile", "Profile",new { id = appUser.Id });
                        }
                        if (!string.IsNullOrWhiteSpace(UserSignInRequestModel.ReturnUrl))
                        {
                            return Redirect(UserSignInRequestModel.ReturnUrl);
                        }

                        IList<string> roles = await _userManager.GetRolesAsync(appUser);
                        if (roles.Contains("Admin"))
                        {
                            return RedirectToAction("CreateProfile", "Home", new { Area = "Admin" });
                        }
                        else if (roles.Contains("Member"))
                        {
                            return RedirectToAction("Privacy");
                        }
                        return RedirectToAction("Panel");
                    }
                    else if (result.IsNotAllowed)
                    {
                        return RedirectToAction("MailPanel");
                    }
                    else if (result.IsLockedOut)
                    {
                        DateTimeOffset? lockOutEndDate = await _userManager.GetLockoutEndDateAsync(appUser);

                        ModelState.AddModelError("", $"Hesabýnýz {(lockOutEndDate.Value.UtcDateTime - DateTime.UtcNow).Minutes} dakika süreyle askýya alýnmýstýr");
                    }
                    else
                    {
                        string message = "";
                        if (appUser != null)
                        {
                            int maxFailedAttempts = _userManager.Options.Lockout.MaxFailedAccessAttempts;

                            message = $"Eger {maxFailedAttempts - await _userManager.GetAccessFailedCountAsync(appUser)} kez daha yanlýs giriþ yaparsanýz hesabýnýz gecici olarak askýya alýnacaktýr";
                        }

                        ModelState.AddModelError("", message);
                    }
                }
                catch (Exception)
                {
                    TempData["Message"] = "Kullanýcý bulunamadý";
                    
                }
                
            }
            return View();
        }
        public IActionResult MailPanel()
        {
            return View();
        }


        [Authorize(Roles = "Member")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Signin");
        }
        
        public async Task<IActionResult> IforgotPassword(UserSignInPageVM model)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(model.Email);

            if (appUser != null)
            {
                Guid token = Guid.NewGuid();
                appUser.ActivationCode = token;
                await _userManager.UpdateAsync(appUser);

                string body = $"Þifre Yenileme için  http://localhost:5014/Home/ResetPassword?token={token}&id={appUser.Id} linkine týklayýnýz";

                MailService.Send(model.Email, body: body);
                TempData["Message"] = "Mailinizi kontrol ediniz";
                return RedirectToAction("SignIn");
            }
            else
            {
                TempData["Message"] = "Bu Maile Ait Kullanýcý Bulunamadý";
                return RedirectToAction("SignIn");
            }
        }


        
        public async Task<IActionResult> ResetPassword(int id , Guid token)
        {
            AppUser user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                TempData["Message"] = "Kullanýcý bulunamadý";
                return RedirectToAction("SignIn");
            }
            else if (user.ActivationCode == token)
            {
                return View();
            }
            TempData["Message"] = "Þifre sýfýrlama iþlemi baþarýsýz oldu. Lütfen daha sonra tekrar deneyin.";
            return RedirectToAction("Signin");
        }

        [IgnoreAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> ResetPassword(UserPasswordPureVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByIdAsync(model.id.ToString());


                IdentityResult result1 = await _userManager.RemovePasswordAsync(user);
                IdentityResult result = await _userManager.AddPasswordAsync(user, model.newPassword);

                if (result.Succeeded)
                {
                    // Þifre sýfýrlama iþlemi baþarýlý olduysa
                    TempData["Message"] = "Þifreniz baþarýyla sýfýrlandý.";
                    return RedirectToAction("SignIn"); // Kullanýcýyý giriþ sayfasýna yönlendir
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
            }
            return View();
        }
    }
}
