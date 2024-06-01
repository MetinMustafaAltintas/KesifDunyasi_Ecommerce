using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Areas.Admin.Models.ProductAttribute.PureVMs
{
    public class AttributeValuePureVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        public string AttributeName { get; set; }

        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        public string Value { get; set; }
    }
}
