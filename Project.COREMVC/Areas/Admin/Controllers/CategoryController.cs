using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Areas.Admin.Models.Category.PageVMs;
using Project.COREMVC.Areas.Admin.Models.Category.PureVMs;
using Project.COREMVC.Areas.Admin.Models.Products.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        readonly ICategoryManager _categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public  IActionResult Index()
        {
            List<Category> categories =  _categoryManager.GetAll();

            List<GetCategoryPureVM> gCvm = categories.Select(gCvm => new GetCategoryPureVM
            {
                ID = gCvm.ID,
                Description = gCvm.Description,
                CategoryName = gCvm.CategoryName,
                Status = gCvm.Status
            }).ToList();

            GetCategoryPageVM getCategory = new GetCategoryPageVM();
            getCategory.GetCategoryPureVMs = gCvm;

            return View(getCategory);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        //Normal şartlarda Domain Entity ile calısmamanız gerekir...BUrada bir CreateCategoryRequestModel gereklidir...

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryPageVM model)
        {
            Category category = new Category();
            category.CategoryName = model.CreateCategoryPureVM.CategoryName;
            category.Description= model.CreateCategoryPureVM.Description;
            await _categoryManager.AddAsync(category);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryManager.Delete(await _categoryManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DestroyCategory(int id)
        {
            TempData["Message"] = _categoryManager.Destroy(await _categoryManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateCategory(int id)
        {
            Category category = await _categoryManager.FindAsync(id);
            UpdateCategoryPureVM  updateCategoryPureVM = new UpdateCategoryPureVM();
            updateCategoryPureVM.ID = category.ID;
            updateCategoryPureVM.CategoryName= category.CategoryName;
            updateCategoryPureVM.Description= category.Description;
            UpdateCategoryPageVM updateCategoryPageVM = new UpdateCategoryPageVM();
            updateCategoryPageVM.UpdateCategoryPureVM= updateCategoryPureVM;
            return View(updateCategoryPageVM);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryPageVM model)
        {
            Category category = new Category();
            category.ID = model.UpdateCategoryPureVM.ID;
            category.CategoryName = model.UpdateCategoryPureVM.CategoryName;
            category.Description = model.UpdateCategoryPureVM.Description;
            await _categoryManager.UpdateAsync(category);
            return RedirectToAction("Index");
        }
    }
}
