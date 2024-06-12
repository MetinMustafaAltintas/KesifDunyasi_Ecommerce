using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Areas.Admin.Models.Shipper.PureVMs
{
    public class UpdateShipperPureVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        public string CompanyName { get; set; }
    }
}
