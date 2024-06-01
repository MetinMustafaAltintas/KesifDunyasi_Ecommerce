using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.COMMON.Tools;
using Project.COREMVC.Areas.Admin.Models.AppRoles.PageVMs;
using Project.COREMVC.Areas.Admin.Models.AppRoles.PureVMs;
using Project.COREMVC.Areas.Admin.Models.User.PageVMs;
using Project.COREMVC.Areas.Admin.Models.User.PureVMs;
using Project.ENTITIES.Models;
using System;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        readonly RoleManager<AppRole> _roleManager;

        public UserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            List<AppUser> nonAdminUsers = _userManager.Users.Where(x => !x.UserRoles.Any(x => x.Role.Name == "Admin")).ToList();
            List<GetUserVM> userVms = nonAdminUsers.Select(user => new GetUserVM
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email
            }).ToList();

            UserPageVM userPageVM = new()
            {
                UserVMs = userVms
            };
            
               
            return View(userPageVM);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserPageVM model)
        {
            if (ModelState.IsValid)
            {
                Guid specId = Guid.NewGuid();
                AppUser appUser = new()
                {
                    UserName = model.CreateUserRequestModel.UserName,
                    Email = model.CreateUserRequestModel.Email,
                    ActivationCode = specId

                };

                IdentityResult result = await _userManager.CreateAsync(appUser, $"Abcdefg1!");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, "Member");
                    string body = $"Hesabınız olusturulmustur...Üyeligini onaylamak icin lütfen http://localhost:5014/Home/ConfirmEmail?specId={specId}&id={appUser.Id} linkine tıklayınız";
                    MailService.Send(model.CreateUserRequestModel.Email, body: body);
                    return RedirectToAction("Index");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View(model);
        }

        public async Task<IActionResult> AssignRole(int id)
        {
            AppUser appUser = await _userManager.Users.SingleOrDefaultAsync(x => x.Id == id);

            IList<string> userRoles = await _userManager.GetRolesAsync(appUser); // Elimize gecen kullanıcının rollerini verir

            List<AppRole> allRoles = _roleManager.Roles.ToList(); //bütün roller

            List<AppRoleResponseModel> roles = new();


            foreach (AppRole role in allRoles)
            {
                roles.Add(new()
                {
                    RoleID = role.Id,
                    RoleName = role.Name,
                    Checked = userRoles.Contains(role.Name)
                });
            }

            AssignRolePageVM arPvm = new()
            {
                UserID = id,
                Roles = roles
            };
            TempData["Message"] = $"Kullanıcı Adı {appUser.UserName}  olan kişinin rol bilgileri";
            return View(arPvm);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(AssignRolePageVM model)
        {
            AppUser appUser = await _userManager.Users.SingleOrDefaultAsync(x => x.Id == model.UserID);
            IList<string> userRoles = await _userManager.GetRolesAsync(appUser);

            foreach (AppRoleResponseModel role in model.Roles)
            {
                if (role.Checked && !userRoles.Contains(role.RoleName)) await _userManager.AddToRoleAsync(appUser, role.RoleName);
                else if (!role.Checked && userRoles.Contains(role.RoleName)) await _userManager.RemoveFromRoleAsync(appUser, role.RoleName);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateUser(string id)
        {
            AppUser appUser = await _userManager.FindByIdAsync(id);

            UpdateUserPureVM Uuserp = new()
            {
                id = id,
                Email = appUser.Email
            };

            UpdateUserPageVM updateUserPageVM = new()
            {
                UpdateUserPureVM = Uuserp,
            };

            return View(updateUserPageVM);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateUserPageVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByIdAsync(model.UpdateUserPureVM.id);
                Guid specId = Guid.NewGuid();
                appUser.Email = model.UpdateUserPureVM.Email;
                appUser.EmailConfirmed = false;
                appUser.ActivationCode = specId;

                IdentityResult result = await _userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                {
                    string body = $"Hesabınızın Mail Adresini onaylamak için  http://localhost:5014/Home/ConfirmEmail?specId={specId}&id={appUser.Id} linkine tıklayınız";

                    MailService.Send(model.UpdateUserPureVM.Email, body: body);
                    TempData["Message"] = "Mail Adresi Değiştirilmiştir";
                    return RedirectToAction("index");
                }
                TempData["Message"] = "Maalesef Hata ile Karşılandı";
                return View(model);
            }
            TempData["Message"] = "Maalesef Hata ile Karşılandı";
            return View(model);
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            AppUser appUser = await _userManager.FindByIdAsync(id);
            _userManager.DeleteAsync(appUser);
            return RedirectToAction("Index");
        }
    }
}
