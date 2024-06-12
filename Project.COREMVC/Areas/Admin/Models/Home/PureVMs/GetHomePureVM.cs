using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Project.COREMVC.Areas.Admin.Models.Home.PureVMs
{
    public class GetHomePureVM
    {
        public string Tarih { get; set; }
        public int KullaniciSayisi { get; set; }
        public int YeniKullanici { get; set; }
        public int UrunSayisi { get; set; }
        public int YeniUrunSayisi { get; set; }
        public int SiparisSayisi { get; set; }
        public int YeniSiparisSayisi { get; set; }
        public string ToplamTutar { get; set; }
        public string GunlukToplamTutar { get; set; }
        public int MaxSatisMiktari { get; set; }
    }
}
