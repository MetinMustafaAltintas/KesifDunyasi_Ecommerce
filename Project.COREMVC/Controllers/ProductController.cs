using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Areas.Admin.Models.ProductAttribute.PureVMs;
using Project.COREMVC.Areas.Admin.Models.Products.PageVMs;
using Project.COREMVC.Areas.Admin.Models.Products.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductManager _productManager;
        readonly IProductAndProductAttributeManager _productAndProductAttributeManager;
        readonly IProductAttributeManager _productAttributeManager;
        public ProductController(IProductManager productManager, IProductAndProductAttributeManager productAndProductAttributeManager, IProductAttributeManager productAttributeManager)
        {
            _productManager = productManager;
            _productAndProductAttributeManager = productAndProductAttributeManager;
            _productAttributeManager = productAttributeManager;
        }

        public async Task<IActionResult> Index(int id)
        {
            Product product = await _productManager.FindAsync(id);
            List<ProductAndProductAttribute> values = _productAndProductAttributeManager.Where(x => x.ProductID == id);

            List<ProductAttribute> attributes = _productAttributeManager.GetActives();

            ProductDetailPageVM productDetailPageVM = new()
            {
                ProductDetails = new GetProductPureVM
                {
                    ID = product.ID,
                    ProductName = product.ProductName,
                    Unitprice = product.UnitPrice,
                    CategoryName = product.Category.CategoryName,
                    ImagePath = product.ImagePath,
                    UnitsInStock = product.UnitsInStock,
                    Status = product.Status
                },
                Attributes = values.Where(v => v.ProductID == id).Join(attributes, v => v.ProductAttributeID, a => a.ID, (v, a) => new AttributeValuePureVM
                {
                    AttributeName = a.AttributeName,
                    Value = v.Value
                }).ToList()

            };

            return View(productDetailPageVM);
        }
    }
}
