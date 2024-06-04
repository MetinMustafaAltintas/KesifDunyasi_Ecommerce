using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Models.Profile.PageVMs;
using Project.COREMVC.Models.Profile.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Controllers
{
    public class ProfileController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        readonly IProfileManager _profileManager;
        public ProfileController(UserManager<AppUser> userManager , IProfileManager profileManager)
        {
            _userManager = userManager;
            _profileManager = profileManager;
        }

        public async Task<IActionResult> Index(string name)
        {
            AppUser appUser = await _userManager.FindByNameAsync(name);

            AppUserProfile userProfile = await _profileManager.FindAsync(appUser.Id);

            GetProfilePureVM getProfile = new GetProfilePureVM();
            getProfile.FirstName = userProfile.FirstName;
            getProfile.LastName = userProfile.LastName;
            getProfile.ImagePath = userProfile.ImagePath;
            getProfile.Birthday = userProfile.Birthday;
            getProfile.Phone = userProfile.Phone;
            getProfile.Country = userProfile.Country;
            getProfile.Ctiy = userProfile.Ctiy;
            getProfile.Email = appUser.Email;

            GetProfilePageVM getProfilePageVM = new GetProfilePageVM();
            getProfilePageVM.GetProfilePureVM= getProfile;
            return View(getProfilePageVM);
        }
    }
}
