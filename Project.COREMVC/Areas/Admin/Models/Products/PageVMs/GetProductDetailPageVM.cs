using Project.COREMVC.Areas.Admin.Models.ProductAndProductAttribute.PureVMs;
using Project.COREMVC.Areas.Admin.Models.ProductAttribute.PureVMs;

namespace Project.COREMVC.Areas.Admin.Models.Products.PageVMs
{
    public class GetProductDetailPageVM
    {
        public List<ProductAttributePureVM> ProductAttributePureVM { get; set; }
        public List<ProductValuesPureVM> ProductValuesPureVM { get; set; }
    }
}
