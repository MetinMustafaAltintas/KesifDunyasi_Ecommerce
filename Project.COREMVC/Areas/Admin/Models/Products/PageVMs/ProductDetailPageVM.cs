using Project.COREMVC.Areas.Admin.Models.ProductAttribute.PureVMs;
using Project.COREMVC.Areas.Admin.Models.Products.PureVMs;

namespace Project.COREMVC.Areas.Admin.Models.Products.PageVMs
{
    public class ProductDetailPageVM
    {
        public GetProductPureVM ProductDetails { get; set; }
        public List<AttributeValuePureVM> Attributes { get; set; }
    }
}
