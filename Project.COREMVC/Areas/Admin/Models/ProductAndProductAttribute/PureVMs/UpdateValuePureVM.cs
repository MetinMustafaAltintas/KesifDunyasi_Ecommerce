using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Areas.Admin.Models.ProductAndProductAttribute.PureVMs
{
    public class UpdateValuePureVM
    {
        public int ProductID { get; set; }
        public int AttributeID { get; set; }
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        public string ValueName { get; set; }
    }
}
