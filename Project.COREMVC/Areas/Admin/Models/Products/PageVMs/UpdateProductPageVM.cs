using Project.COREMVC.Areas.Admin.Models.Category.PureVMs;
using Project.COREMVC.Areas.Admin.Models.Products.PureVMs;

namespace Project.COREMVC.Areas.Admin.Models.Products.PageVMs
{
    public class UpdateProductPageVM
    {
        public UpdateProductPureVM Product { get; set; }
        public List<CategoryPureVm> Categories { get; set; }
    }
}
