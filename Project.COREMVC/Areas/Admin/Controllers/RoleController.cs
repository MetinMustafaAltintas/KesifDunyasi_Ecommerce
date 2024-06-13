using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.COREMVC.Areas.Admin.Models.AppRoles.PageVMs;
using Project.COREMVC.Areas.Admin.Models.AppRoles.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [AutoValidateAntiforgeryToken]
    public class RoleController : Controller
    {
        readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            List<AppRole> userAppRole = await _roleManager.Roles.ToListAsync();

            List<GetRolePureVM> rolePureVMs = userAppRole.Select(rolePureVMs => new GetRolePureVM
            {
                ID = rolePureVMs.Id,
                RolName = rolePureVMs.Name,
                Status = rolePureVMs.Status
            }).ToList();

            AppRolePageVM appRolePageVM  = new()
            {
                RolePureVM = rolePureVMs,
            };
            return View(appRolePageVM);
        }

        
        public async Task<IActionResult>RoleCreate(AppRolePageVM model)
        {
           
            IdentityResult result = await _roleManager.CreateAsync(new()
            {
                Name = model.CreateRolePureVM.RoleName
            });

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateRole(string id)
        {
            AppRole Role = await _roleManager.FindByIdAsync(id);

            UpdateRolePureVM rolePureVM = new()
            {
                ID = Role.Id.ToString(),
                RoleName = Role.Name
            };

            UpdateRolePageVM rolePageVM = new();
            rolePageVM.UpdateRolePureVM = rolePureVM;
            return View(rolePageVM);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRolePageVM model)
        {
            if (ModelState.IsValid)
            {
                AppRole role = await _roleManager.FindByIdAsync(model.UpdateRolePureVM.ID);
                if (role == null)
                {
                    TempData["Message"] = "Rol Bulunamadı";
                    return View();
                }

                role.Name = model.UpdateRolePureVM.RoleName;
                role.ModifiedDate = DateTime.Now;
                role.Status = ENTITIES.Enums.DataStatus.Updated;
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }
            return View(model);
        }

        public async Task<IActionResult> DeleteRole(string id)
        {
            AppRole role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                if (role.Status == ENTITIES.Enums.DataStatus.Deleted)
                {
                    await _roleManager.DeleteAsync(role);
                    TempData["Message"] = "Rol Silindi";
                    return RedirectToAction("Index");
                }
                TempData["Message"] = "Rol Pasif Değil";
                return RedirectToAction("Index");
            }
            TempData["Message"] = "Rol Bulunamadı";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> PassiveRole(string id)
        {
            AppRole role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                role.Status = ENTITIES.Enums.DataStatus.Deleted;
                IdentityResult result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    TempData["Message"] = "Rol Pasife Alındı";
                    return RedirectToAction("Index");
                }
                TempData["Message"] = "Rol Pasife Alınamadı";
                return RedirectToAction("Index");
            }
            TempData["Message"] = "Rol Bulunamadı";
            return RedirectToAction("Index");
        }
    }
}
