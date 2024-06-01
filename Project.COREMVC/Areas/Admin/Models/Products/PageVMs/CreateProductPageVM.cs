using Project.COREMVC.Areas.Admin.Models.Category.PureVMs;
using Project.COREMVC.Areas.Admin.Models.Products.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Models.Products.PageVMs
{
    public class CreateProductPageVM
    {
        public List<CategoryPureVm> Categories { get; set; }
        public CreateProductPureVm Product { get; set; }
    }
}
