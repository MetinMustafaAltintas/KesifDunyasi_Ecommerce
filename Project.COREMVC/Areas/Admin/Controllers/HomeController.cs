using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Areas.Admin.Models.Home.PageVMs;
using Project.COREMVC.Areas.Admin.Models.Home.PureVMs;
using Project.ENTITIES.Models;
using System.Globalization;

namespace Project.COREMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        readonly IOrderManager _orderManager;
        readonly UserManager<AppUser> _userManager;
        readonly IOrderDetailManager _orderDetailManager;
        public HomeController(IOrderManager orderManager, UserManager<AppUser> userManager , IOrderDetailManager orderDetailManager)
        {
            _orderManager = orderManager;
            _userManager = userManager;
            _orderDetailManager = orderDetailManager;
        }

        public  IActionResult Index()
        {
            DateTime tarih = DateTime.Now;
            CultureInfo tarihFormati = new CultureInfo("tr-TR");
            string trTarih = tarih.ToString("dd.MM.yyyy - dddd", tarihFormati);

            int UserCount = _userManager.Users.ToList().Count();
            int NewUserCount = _userManager.Users.ToList().Where(x => x.CreatedDate.Day == DateTime.Now.Day).Count();

            int urunSayisi = _orderDetailManager.GetAll().Sum(x => x.Quantity);
            int gunlukUrunSayisi = _orderDetailManager.GetAll().Where(x=>x.CreatedDate.Day == DateTime.Now.Day).Sum(x => x.Quantity);

            int siparisSayisi = _orderManager.GetAll().Count();
            int gunlukSiparisSayisi = _orderManager.GetAll().Where(x => x.CreatedDate.Day == DateTime.Now.Day).Count();

            string toplamTutar = _orderManager.GetAll().Sum(x => x.PriceOfOrder).ToString("C", new CultureInfo("tr-TR"));
            string gunlukToplamTutar = _orderManager.GetAll().Where(x => x.CreatedDate.Day == DateTime.Now.Day).Sum(x => x.PriceOfOrder).ToString("C", new CultureInfo("tr-TR"));

            List<AylikSatisPureVM> aylikSatis = new List<AylikSatisPureVM>
            {
            new() { AyAdi = "OCA", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 1).Sum(x =>x.PriceOfOrder))},
            new() { AyAdi = "ŞUB", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 2).Sum(x =>x.PriceOfOrder))},
            new() { AyAdi = "MAR", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 3).Sum(x => x.PriceOfOrder)) },
            new() { AyAdi = "NİS", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 4).Sum(x => x.PriceOfOrder)) },
            new() { AyAdi = "MAY", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 5).Sum(x => x.PriceOfOrder)) },
            new() { AyAdi = "HAZ", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 6).Sum(x => x.PriceOfOrder)) },
            new() { AyAdi = "TEM", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 7).Sum(x => x.PriceOfOrder)) },
            new() { AyAdi = "AĞU", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 8).Sum(x => x.PriceOfOrder)) },
            new() { AyAdi = "EYL", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 9).Sum(x => x.PriceOfOrder)) },
            new() { AyAdi = "EKİ", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 10).Sum(x => x.PriceOfOrder)) },
            new() { AyAdi = "KAS", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 11).Sum(x => x.PriceOfOrder)) },
            new() { AyAdi = "ARA", SatisMiktari =Convert.ToInt32(_orderManager.GetAll().Where(x =>x.CreatedDate.Month == 12).Sum(x => x.PriceOfOrder)) }
            };
            int maxSatisMiktari = aylikSatis.Max(x => x.SatisMiktari);

            
            GetHomePureVM getHomePureVM = new GetHomePureVM();
            getHomePureVM.Tarih = trTarih;
            getHomePureVM.KullaniciSayisi = UserCount;
            getHomePureVM.YeniKullanici = NewUserCount;
            getHomePureVM.UrunSayisi = urunSayisi;
            getHomePureVM.YeniUrunSayisi = gunlukUrunSayisi;
            getHomePureVM.SiparisSayisi = siparisSayisi;
            getHomePureVM.YeniSiparisSayisi = gunlukSiparisSayisi;
            getHomePureVM.ToplamTutar = toplamTutar;
            getHomePureVM.GunlukToplamTutar = gunlukToplamTutar;
            getHomePureVM.MaxSatisMiktari = maxSatisMiktari;

            GetHomePageVM getHomePageVM = new GetHomePageVM();
            getHomePageVM.GetHomePureVM = getHomePureVM;
            getHomePageVM.aylikSatisPureVMs = aylikSatis;

            return View(getHomePageVM);
        }
    }
}
