namespace Project.COREMVC.Models.Orders.PureVMs
{
    public class ListOrderPureVM
    {
        public int ID { get; set; }
        public string IsimSoyisim { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public decimal SiparisTutari { get; set; }
        public string KargoFirmasi { get; set; }
    }
}
