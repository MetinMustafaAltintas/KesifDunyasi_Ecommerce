using Microsoft.EntityFrameworkCore.Metadata;
using Project.ENTITIES.Enums;

namespace Project.COREMVC.Areas.Admin.Models.Category.PureVMs
{
    public class GetCategoryPureVM
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DataStatus Status { get; set; }
    }
}
