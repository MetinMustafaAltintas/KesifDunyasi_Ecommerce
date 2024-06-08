using Project.ENTITIES.Enums;

namespace Project.COREMVC.Areas.Admin.Models.Order.PureVMs
{
    public class GetOrderPureVM
    {
        public int ID { get; set; }
        public string ShippingAddress { get; set; }
        public string Email { get; set; } 
        public string NameDescription { get; set; } 
        public int? AppUserID { get; set; } //null gecilebiliyorsa anlayın ki kullanıcı üye degildir..
        public decimal PriceOfOrder { get; set; } //Siparişin toplam fiyatı(Sepetin onaylanan fiyatı)
        public string Shipper { get; set; }
        public DataStatus Status { get; set; }
    }
}
