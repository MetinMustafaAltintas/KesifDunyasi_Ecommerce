using Project.ENTITIES.Enums;

namespace Project.COREMVC.Areas.Admin.Models.Products.PureVMs
{
    public class GetProductPureVM
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Unitprice { get; set; }
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }
        public int UnitsInStock { get; set; }
        public DataStatus Status { get; set; }


    }
}
