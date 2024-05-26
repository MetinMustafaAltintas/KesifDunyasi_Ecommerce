using Project.COREMVC.Areas.Admin.Models.AppRoles.PureVMs;

namespace Project.COREMVC.Areas.Admin.Models.AppRoles.PageVMs
{
    public class AssignRolePageVM
    {
        public List<AppRoleResponseModel> Roles { get; set; }
        public int UserID { get; set; }
    }
}
