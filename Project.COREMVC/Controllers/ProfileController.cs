using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Models.Profile.PageVMs;
using Project.COREMVC.Models.Profile.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Controllers
{
    [AutoValidateAntiforgeryToken]
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
            if (userProfile == null)
            {
                return RedirectToAction("CreateProfile", new { id = appUser.Id });
            }

            GetProfilePureVM getProfile = new GetProfilePureVM();
            getProfile.ID = userProfile.ID;
            getProfile.FirstName = userProfile.FirstName;
            getProfile.LastName = userProfile.LastName;
            getProfile.ImagePath = userProfile.ImagePath;
            getProfile.Birthday = (DateTime)userProfile.Birthday;
            getProfile.Phone = userProfile.Phone;
            getProfile.Country = userProfile.Country;
            getProfile.City = userProfile.City;
            getProfile.Email = appUser.Email;

            GetProfilePageVM getProfilePageVM = new GetProfilePageVM();
            getProfilePageVM.GetProfilePureVM= getProfile;
            return View(getProfilePageVM);
        }

        public IActionResult CreateProfile(int id)
        {
            CreateProfilePureVM vm = new CreateProfilePureVM();
            vm.ID = id;
            CreateProfilePageVM get = new CreateProfilePageVM();
            get.CreateProfilePureVM = vm;
            return View(get);
            
        }
        [HttpPost]
        public async Task<IActionResult> CreateProfile(CreateProfilePageVM model , IFormFile formFile)
        {
            
            if (formFile != null)
            {
                Guid uniqueName = Guid.NewGuid();
                string extension = Path.GetExtension(formFile.FileName);//dosyanın uzantısını ele gecirdik...
                model.CreateProfilePureVM.ImagePath = $"/images/{uniqueName}{extension}";
           
                string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.CreateProfilePureVM.ImagePath}";
                FileStream stream = new(path, FileMode.Create);
                formFile.CopyTo(stream);
            }
            AppUserProfile appUserProfile = new AppUserProfile();
            appUserProfile.ID = model.CreateProfilePureVM.ID;
            appUserProfile.FirstName = model.CreateProfilePureVM.FirstName;
            appUserProfile.LastName = model.CreateProfilePureVM.LastName;
            appUserProfile.Country = model.CreateProfilePureVM.Country;
            appUserProfile.City = model.CreateProfilePureVM.City;
            appUserProfile.Birthday = model.CreateProfilePureVM.Birthday;
            appUserProfile.ImagePath = model.CreateProfilePureVM.ImagePath;
            appUserProfile.Phone = model.CreateProfilePureVM.Phone;
           
            _profileManager.Add(appUserProfile);
            AppUser appUser = await _userManager.FindByIdAsync(appUserProfile.ID.ToString());
            return RedirectToAction("Index", new { name = appUser.UserName });
         
        }

        public async Task<IActionResult> UpdateProfile(int id)
        {
            AppUserProfile userProfile = await _profileManager.FindAsync(id);

            UpdateProfilePureVM profilePureVM = new UpdateProfilePureVM();
            profilePureVM.ID = userProfile.ID; ;
            profilePureVM.FirstName = userProfile.FirstName;
            profilePureVM.LastName = userProfile.LastName;
            profilePureVM.Birthday = userProfile.Birthday;
            profilePureVM.ImagePath = userProfile.ImagePath;
            profilePureVM.Country = userProfile.Country;
            profilePureVM.City = userProfile.City;
            profilePureVM.Phone = userProfile.Phone;

            UpdateProfilePageVM profilePageVM = new UpdateProfilePageVM();
            profilePageVM.UpdateProfilePureVM = profilePureVM;
            return View(profilePageVM);
        }
        [HttpPost]
        public async Task<ActionResult> UpdateProfile(UpdateProfilePageVM model, IFormFile formFile)
        {
           
            if (formFile != null)
            {
                Guid uniqueName = Guid.NewGuid();
                string extension = Path.GetExtension(formFile.FileName);//dosyanın uzantısını ele gecirdik...
                model.UpdateProfilePureVM.ImagePath = $"/images/{uniqueName}{extension}";

                string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.UpdateProfilePureVM.ImagePath}";
                FileStream stream = new(path, FileMode.Create);
                formFile.CopyTo(stream);

            }
            AppUserProfile appUserProfile = new AppUserProfile();
            appUserProfile.ID = model.UpdateProfilePureVM.ID;
            appUserProfile.FirstName = model.UpdateProfilePureVM.FirstName;
            appUserProfile.LastName = model.UpdateProfilePureVM.LastName;
            appUserProfile.Birthday = model.UpdateProfilePureVM.Birthday;
            appUserProfile.Country = model.UpdateProfilePureVM.Country;
            appUserProfile.City = model.UpdateProfilePureVM.City;
            appUserProfile.Phone = model.UpdateProfilePureVM.Phone;
            appUserProfile.ImagePath = model.UpdateProfilePureVM.ImagePath;


            await _profileManager.UpdateAsync(appUserProfile);
            AppUser appUser = await _userManager.FindByIdAsync(appUserProfile.ID.ToString());
            return RedirectToAction("Index", new { name = appUser.UserName });
           
        }
    }
}
