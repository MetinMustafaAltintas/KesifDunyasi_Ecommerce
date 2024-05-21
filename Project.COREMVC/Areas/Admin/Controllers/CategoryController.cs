using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
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

        public IActionResult Index()
        {
            return View(_categoryManager.GetAll());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        //Normal şartlarda Domain Entity ile calısmamanız gerekir...BUrada bir CreateCategoryRequestModel gereklidir...

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category model)
        {
            await _categoryManager.AddAsync(model);
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
            return View(await _categoryManager.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Category model)
        {
            await _categoryManager.UpdateAsync(model);
            return RedirectToAction("Index");
        }
    }
}
