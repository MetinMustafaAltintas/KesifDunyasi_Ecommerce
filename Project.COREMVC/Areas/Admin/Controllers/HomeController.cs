using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Areas.Admin.Models.Home.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        readonly IOrderManager _orderManager;
        readonly UserManager<AppUser> _userManager;
        readonly RoleManager<AppRole> _roleManager;
        public HomeController(IOrderManager orderManager, UserManager<AppUser> userManager , RoleManager<AppRole> roleManager)
        {
            _orderManager = orderManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            int UserCount = _userManager.Users.Count();
            List<AppUser> users = new List<AppUser>();
            UserCount = users.Where(x => x.CreatedDate == DateTime.Now).Count();


            GetHomePureVM getHomePureVM = new GetHomePureVM();
            getHomePureVM.KullaniciSayisi = UserCount;
            return View(getHomePureVM);
        }
    }
}
