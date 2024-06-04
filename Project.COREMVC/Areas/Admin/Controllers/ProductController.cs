using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Project.BLL.Managers.Abstracts;
using Project.BLL.Managers.Concretes;
using Project.BLL.ServiceInjections;
using Project.COREMVC.Areas.Admin.Models.AppRoles.PureVMs;
using Project.COREMVC.Areas.Admin.Models.Category.PureVMs;
using Project.COREMVC.Areas.Admin.Models.ProductAndProductAttribute.PureVMs;
using Project.COREMVC.Areas.Admin.Models.ProductAttribute.PageVMs;
using Project.COREMVC.Areas.Admin.Models.ProductAttribute.PureVMs;
using Project.COREMVC.Areas.Admin.Models.Products.PageVMs;
using Project.COREMVC.Areas.Admin.Models.Products.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        readonly IProductManager _productManager;
        readonly ICategoryManager _categoryManager;
        readonly IProductAndProductAttributeManager _productAndProductAttributeManager;
        readonly IProductAttributeManager _productAttributeManager;

        public ProductController(IProductManager productManager, ICategoryManager categoryManager, IProductAndProductAttributeManager productAndProductAttributeManager, IProductAttributeManager productAttributeManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _productAndProductAttributeManager = productAndProductAttributeManager;
            _productAttributeManager = productAttributeManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> productlist =  _productManager.GetAll();

            List<GetProductPureVM> pPvm = productlist.Select(pPvm => new GetProductPureVM
            {
                ID = pPvm.ID,
                ProductName = pPvm.ProductName,
                Unitprice = pPvm.UnitPrice,
                UnitsInStock = pPvm.UnitsInStock,
                ImagePath = pPvm.ImagePath,
                CategoryName = pPvm.Category.CategoryName,
                Status = pPvm.Status
            }).ToList();

            GetProductPageVM gPPvm = new()
            {
                GetProductPureVM = pPvm
            };

            return View(gPPvm);
        }

        public async Task<IActionResult> CreateProduct()
        {
            List<Category> category = await _categoryManager.GetActivesAsync();

            List<CategoryPureVm> cPvms = category.Select(cPvm => new CategoryPureVm
            {
                ID = cPvm.ID,
                CategoryName = cPvm.CategoryName
            }).ToList();

            CreateProductPageVM cpVm = new()
            {
                Categories = cPvms
            };
            return View(cpVm);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductPageVM CreateProductPageVM, IFormFile formFile)
        {
            Guid uniqueName = Guid.NewGuid();
            string extension = Path.GetExtension(formFile.FileName); //dosyanın uzantısını ele gecirdik...
            CreateProductPageVM.Product.ImagePath = $"/images/{uniqueName}{extension}";

            string path = $"{Directory.GetCurrentDirectory()}/wwwroot{CreateProductPageVM.Product.ImagePath}";
            FileStream stream = new(path, FileMode.Create);
            formFile.CopyTo(stream);

            Product product = new Product();
            product.ProductName = CreateProductPageVM.Product.ProductName;
            product.UnitPrice = CreateProductPageVM.Product.Unitprice;
            product.UnitsInStock = CreateProductPageVM.Product.UnitsInStock;
            product.ImagePath = CreateProductPageVM.Product.ImagePath;
            product.CategoryID = CreateProductPageVM.Product.CategoryID;

            _productManager.Add(product);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id == null)
            {
                TempData["Message"] = "Ürün Bulunamadı";
                return RedirectToAction("Index");
            }
            else
            {
                _productManager.Delete(await _productManager.FindAsync(id));
                TempData["Message"] = "Ürün Pasife Alındı";
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> DestroyProduct(int id)
        {
            if (id == null)
            {
                TempData["Message"] = "Ürün Bulunamadı";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = _productManager.Destroy(await _productManager.FindAsync(id));
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> UpdateProduct(int id)
        {
            Product product = await _productManager.FindAsync(id);

            List<Category> category = await _categoryManager.GetActivesAsync();

            List<CategoryPureVm> cPvms = category.Select(cPvm => new CategoryPureVm
            {
                ID = cPvm.ID,
                CategoryName = cPvm.CategoryName
            }).ToList();

            UpdateProductPureVM uPPvm = new UpdateProductPureVM();
            uPPvm.ID = product.ID;
            uPPvm.ProductName = product.ProductName;
            uPPvm.Unitprice = product.UnitPrice;
            uPPvm.UnitsInStock = product.UnitsInStock;
            uPPvm.ImagePath = product.ImagePath;
            uPPvm.CategoryID = (int)product.CategoryID;

            UpdateProductPageVM uPPvms = new UpdateProductPageVM();
            uPPvms.Product = uPPvm;
            uPPvms.Categories = cPvms;


            return View(uPPvms);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductPageVM UpdateProductPageVM, IFormFile formFile)
        {
            if (formFile != null)
            {
                Guid uniqueName = Guid.NewGuid();
                string extension = Path.GetExtension(formFile.FileName); //dosyanın uzantısını ele gecirdik...
                UpdateProductPageVM.Product.ImagePath = $"/images/{uniqueName}{extension}";

                string path = $"{Directory.GetCurrentDirectory()}/wwwroot{UpdateProductPageVM.Product.ImagePath}";
                FileStream stream = new(path, FileMode.Create);
                formFile.CopyTo(stream);

                Product product = new Product();
                product.ID = UpdateProductPageVM.Product.ID;
                product.ProductName = UpdateProductPageVM.Product.ProductName;
                product.UnitPrice = UpdateProductPageVM.Product.Unitprice;
                product.UnitsInStock = UpdateProductPageVM.Product.UnitsInStock;
                product.ImagePath = UpdateProductPageVM.Product.ImagePath;
                product.CategoryID = UpdateProductPageVM.Product.CategoryID;
                await _productManager.UpdateAsync(product);
                TempData["Message"] = $"{product.ProductName} Ürün Güncellendi";
                return RedirectToAction("Index");

            }
            else
            {
                Product product = new Product();
                product.ID = UpdateProductPageVM.Product.ID;
                product.ProductName = UpdateProductPageVM.Product.ProductName;
                product.UnitPrice = UpdateProductPageVM.Product.Unitprice;
                product.UnitsInStock = UpdateProductPageVM.Product.UnitsInStock;
                product.CategoryID = UpdateProductPageVM.Product.CategoryID;
                product.ImagePath = UpdateProductPageVM.Product.ImagePath;
                await _productManager.UpdateAsync(product);
                TempData["Message"] = $"{product.ProductName} Ürün Güncellendi";
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> ProductProperty(int id)
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

        public async Task<IActionResult> CreateProductProperty(int id)
        {
            AttributeValuePureVM attributeValuePureVM = new AttributeValuePureVM();
            attributeValuePureVM.ID = id;
            CreateAttribuePageVM cApvm = new CreateAttribuePageVM();
            cApvm.AttributeValueVM = attributeValuePureVM;

            return View(cApvm);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductProperty(CreateAttribuePageVM model)
        {
            Product product = await _productManager.FindAsync(model.AttributeValueVM.ID);
            if (product != null)
            {
                List<ProductAttribute> attributes = await _productAttributeManager.GetActivesAsync();

                ProductAttribute productAttribute = new ProductAttribute();
                productAttribute.AttributeName = model.AttributeValueVM.AttributeName;
                productAttribute.AttributeName = productAttribute.AttributeName.ToTitleCase();
                int eskiID = productAttribute.ID;
                foreach (ProductAttribute item in attributes)
                {
                    if (item.AttributeName == productAttribute.AttributeName)
                    {
                        productAttribute.ID= item.ID;
                        break;
                    }
                }
                if (eskiID == productAttribute.ID)
                {
                    _productAttributeManager.Add(productAttribute);
                }
                ProductAndProductAttribute ayniozellikvarmi = _productAndProductAttributeManager.Where(x => x.ProductID == product.ID && x.ProductAttributeID == productAttribute.ID).FirstOrDefault();

                if (ayniozellikvarmi != null)
                {
                    TempData["Message"] = $"{product.ProductName} isimli üründe {productAttribute.AttributeName} özelliği bulunuyor";
                    return RedirectToAction("ProductProperty", new { id = model.AttributeValueVM.ID });
                }

                ProductAndProductAttribute pAppa = new ProductAndProductAttribute();
                pAppa.ProductID = product.ID;
                pAppa.ProductAttributeID = productAttribute.ID;
                pAppa.Value = model.AttributeValueVM.Value;
                _productAndProductAttributeManager.Add(pAppa);

                TempData["Message"] = $"{product.ProductName} Ürün Güncellendi";
                return RedirectToAction("ProductProperty", new { id = model.AttributeValueVM.ID });
            }
            else
            {
                TempData["Message"] = "Ürün Bulunamadı";
                return RedirectToAction("ProductProperty", new { id = model.AttributeValueVM.ID });
            }
        }

        public async Task<IActionResult> GetProductProperty(int id)
        {
            Product product = await _productManager.FindAsync(id);

            List<ProductAndProductAttribute> values = _productAndProductAttributeManager.Where(x => x.ProductID == id);

            List<ProductAttribute> attributes = await _productAttributeManager.GetActivesAsync();

            List<ProductAttribute> relatedAttributes = attributes.Where(attr => values.Any(val => val.ProductAttributeID == attr.ID)).ToList();

            List<ProductAttributePureVM> attributePureVMs = new List<ProductAttributePureVM>();
            foreach (ProductAttribute attr in relatedAttributes)
            {
                ProductAttributePureVM attributePureVM = new ProductAttributePureVM();
                attributePureVM.AttributeID = attr.ID;
                attributePureVM.AttributeName = attr.AttributeName;
                attributePureVMs.Add(attributePureVM);
            };
            List<ProductValuesPureVM> productValuesPureVMs = new List<ProductValuesPureVM>();

            foreach (ProductAndProductAttribute productAttribute in values)
            {
                ProductValuesPureVM pVpvm = new ProductValuesPureVM();
                pVpvm.Values = productAttribute.Value;
                pVpvm.AttributeID = productAttribute.ProductAttributeID;
                pVpvm.ProductID = product.ID;
                productValuesPureVMs.Add(pVpvm);
            };


            GetProductDetailPageVM updateProductDetailPageVM = new GetProductDetailPageVM();
            updateProductDetailPageVM.ProductAttributePureVM = attributePureVMs;
            updateProductDetailPageVM.ProductValuesPureVM = productValuesPureVMs;

            return View(updateProductDetailPageVM);
        }

        public IActionResult UpdateAttribute(int id)
        {
            UpdateAttribuePureVM attribute = new UpdateAttribuePureVM();
            attribute.ID=id;
            UpdateAttribuePageVM updateAttribue = new UpdateAttribuePageVM();
            updateAttribue.UpdateAttribuePureVM = attribute;
            return View(updateAttribue);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAttribute(UpdateAttribuePageVM updateAttribue)
        {
            ProductAttribute attribute = new ProductAttribute();
            attribute.ID = updateAttribue.UpdateAttribuePureVM.ID;
            attribute.AttributeName = updateAttribue.UpdateAttribuePureVM.AttributeName;
            await _productAttributeManager.UpdateAsync(attribute);
            TempData["Message"] = $"{attribute.AttributeName}  Güncellendi";
            return RedirectToAction("index");
        }

        public async Task<IActionResult> DeleteAttribute(int id)
        {
            if (id == null)
            {
                TempData["Message"] = "Attribute Bulunamadı";
                return RedirectToAction("index");
            }
            else
            {
                TempData["Message"] = _productAttributeManager.Destroy(await _productAttributeManager.FindAsync(id));
                return RedirectToAction("index");
            }
        }
        public IActionResult UpdateValue(int AttributeID , int ProductID)
        {
            UpdateValuePureVM value = new UpdateValuePureVM();
            value.AttributeID = AttributeID;
            value.ProductID = ProductID;
            UpdateValuePageVM valuePageVM = new UpdateValuePageVM();
            valuePageVM.UpdateValuePureVM = value;
            return View(valuePageVM);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateValue(UpdateValuePageVM valuePageVM)
        {
            ProductAndProductAttribute value = new ProductAndProductAttribute();
            value.ProductID = valuePageVM.UpdateValuePureVM.ProductID;
            value.ProductAttributeID = valuePageVM.UpdateValuePureVM.AttributeID;
            value.Value = valuePageVM.UpdateValuePureVM.ValueName;

            ProductAndProductAttribute orginaldata = _productAndProductAttributeManager.Where(x => x.ProductID == value.ProductID && x.ProductAttributeID == value.ProductAttributeID).FirstOrDefault();

            _productAndProductAttributeManager.Updated(value, orginaldata);
            TempData["Message"] = $"{value.Value}  Güncellendi";
            return RedirectToAction("GetProductProperty", new { id = valuePageVM.UpdateValuePureVM.ProductID });
        }

        public async Task<IActionResult> DeleteValue(int AttributeID, int ProductID)
        {

            ProductAndProductAttribute orginaldata = _productAndProductAttributeManager.Where(x => x.ProductID == ProductID && x.ProductAttributeID == AttributeID).FirstOrDefault();

            TempData["Message"] = _productAndProductAttributeManager.Destroy(orginaldata);
            return RedirectToAction("index");
            
        }
    }
}
 