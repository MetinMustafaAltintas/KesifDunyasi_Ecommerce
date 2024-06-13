using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Areas.Admin.Models.Shipper.PageVMs;
using Project.COREMVC.Areas.Admin.Models.Shipper.PureVMs;
using Project.ENTITIES.Models;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [AutoValidateAntiforgeryToken]
    public class ShipperController : Controller
    {
        readonly IShipperManager _shipperManager;
        public ShipperController(IShipperManager shipperManager)
        {
            _shipperManager = shipperManager;
        }

        public IActionResult Index()
        {
            List<Shipper> shippers = _shipperManager.GetAll();

            List<GetShipperPureVM> getShippers = shippers.Select(getShippers => new GetShipperPureVM
            {
                ID = getShippers.ID,
                CompanyName = getShippers.CompanyName,
                Status = getShippers.Status
            }).ToList();
            GetShipperPageVM getShipperPageVM = new GetShipperPageVM();
            getShipperPageVM.GetShipperPureVMs = getShippers;

            return View(getShipperPageVM);
        }

        public IActionResult CreateShipper()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateShipper(CreateShipperPageVM model)
        {
            if (ModelState.IsValid)
            {
                Shipper shipper = new Shipper();
                shipper.CompanyName = model.CreateShipperPureVM.CompanyName;
                _shipperManager.AddAsync(shipper);
                TempData["Message"] = $"{shipper.CompanyName} verisi eklendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> UpdateShipper(int id)
        {
            Shipper shipper = await _shipperManager.FindAsync(id);

            UpdateShipperPureVM shipperPureVM = new()
            {
                ID = shipper.ID,
                CompanyName = shipper.CompanyName,
            };

            UpdateShipperPageVM shipperPageVM = new()
            {
                UpdateShipperPureVM = shipperPureVM
            };
            return View(shipperPageVM);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateShipper(UpdateShipperPageVM model)
        {
            if (ModelState.IsValid)
            {
                Shipper shipper = await _shipperManager.FindAsync(model.UpdateShipperPureVM.ID);
                shipper.CompanyName=model.UpdateShipperPureVM.CompanyName;
                await _shipperManager.UpdateAsync(shipper);
                TempData["Message"] = $"{shipper.CompanyName} verisi güncellendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> PassiveShipper(int id)
        {
            _shipperManager.Delete(await _shipperManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteShipper(int id)
        {
            TempData["Message"] = _shipperManager.Destroy(await _shipperManager.FindAsync(id));
            return RedirectToAction("Index");
        }
    }
}
