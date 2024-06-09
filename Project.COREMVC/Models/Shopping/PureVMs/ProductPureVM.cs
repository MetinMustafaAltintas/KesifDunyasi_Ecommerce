namespace Project.COREMVC.Models.Shopping.PureVMs
{
    public class ProductPureVM
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
