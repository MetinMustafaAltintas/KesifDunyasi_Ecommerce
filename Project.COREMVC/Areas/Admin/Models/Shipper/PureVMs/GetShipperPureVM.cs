using Project.ENTITIES.Enums;

namespace Project.COREMVC.Areas.Admin.Models.Shipper.PureVMs
{
    public class GetShipperPureVM
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public DataStatus Status { get; set; }
    }
}
