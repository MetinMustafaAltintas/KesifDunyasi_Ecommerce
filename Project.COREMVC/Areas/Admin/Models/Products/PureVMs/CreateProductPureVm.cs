using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Areas.Admin.Models.Products.PureVMs
{
    public class CreateProductPureVm
    {
        [Required(ErrorMessage = "Ürün ismi girilmesi zorunludur")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Ürün Fiyatı girilmesi zorunludur")]
        [Range(0, double.MaxValue, ErrorMessage = "Lütfen geçerli bir sayı giriniz.")]
        public decimal Unitprice { get; set; }
        [Required(ErrorMessage = "Ürün Stok girilmesi zorunludur")]
        [Range(0,int.MaxValue, ErrorMessage = "Lütfen geçerli bir sayı giriniz.")]
        public int UnitsInStock { get; set; }
        public string ImagePath { get; set; }
        public int CategoryID { get; set; }
        
    }
}
