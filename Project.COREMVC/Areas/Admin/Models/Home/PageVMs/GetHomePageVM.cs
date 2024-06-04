using Project.COREMVC.Areas.Admin.Models.Home.PureVMs;

namespace Project.COREMVC.Areas.Admin.Models.Home.PageVMs
{
    public class GetHomePageVM
    {
        public GetHomePureVM GetHomePureVM { get; set; }
        public List<AylikSatisPureVM> aylikSatisPureVMs { get; set; }
    }
}
