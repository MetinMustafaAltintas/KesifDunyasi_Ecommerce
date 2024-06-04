using System.ComponentModel.DataAnnotations;

namespace Project.COREMVC.Models.Profile.PureVMs
{
    public class CreateProfilePureVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Girilmesi zorunludur")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Girilmesi zorunludur")]
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Girilmesi zorunludur")]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "Girilmesi zorunludur")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Girilmesi zorunludur")]
        public string City { get; set; }
        [Required(ErrorMessage = "Girilmesi zorunludur")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Telefon numarası 11 rakamdan oluşmalıdır.")]
        public string Phone { get; set; }
    }
}
