using Project.COREMVC.Areas.Admin.Models.AppRoles.PureVMs;
using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Areas.Admin.Models.AppRoles.PageVMs
{
    public class AppRolePageVM
    {
        public List<GetRolePureVM> RolePureVM { get; set; }
        public CreateRolePureVM CreateRolePureVM { get; set; }

       
    }
}
