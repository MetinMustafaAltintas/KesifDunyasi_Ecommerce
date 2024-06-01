using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Areas.Admin.Models.Products.PureVMs
{
    public class UpdateProductPureVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ürün ismi girilmesi zorunludur")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Ürün Fiyatı girilmesi zorunludur")]
        public decimal Unitprice { get; set; }
        [Required(ErrorMessage = "Ürün Stok girilmesi zorunludur")]
        public int UnitsInStock { get; set; }
        public string ImagePath { get; set; }
        public int CategoryID { get; set; }
    }
}
