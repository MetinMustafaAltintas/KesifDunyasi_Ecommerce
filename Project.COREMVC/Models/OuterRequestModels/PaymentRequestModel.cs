using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.OuterRequestModels
{
    public class PaymentRequestModel
    {
        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Kart üzerindeki Isim Soyisim 2 ile 100 karakter arasında olmalıdır.")]
        public string CardUserName { get; set; }

        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [RegularExpression(@"^\d{3,4}$", ErrorMessage = "CCV 3 veya 4 basamaklı bir sayı olmalıdır.")]
        public string CCV { get; set; }

        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [Range(2023, 2100, ErrorMessage = "Geçerli bir Yıl Giriniz")]
        public int ExpiryYear { get; set; }

        [Required(ErrorMessage = "{0} Girilmesi Zorunludur")]
        [Range(1, 12, ErrorMessage = "Geçerli bir Ay Giriniz")]
        public int ExpiryMonth { get; set; }
        public decimal ShoppingPrice { get; set; }

    }
}

