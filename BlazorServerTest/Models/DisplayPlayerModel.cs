using System.ComponentModel.DataAnnotations;

namespace BlazorServerTest.Models
{
    public class DisplayPlayerModel
    {
        [Required]
        [StringLength(50,ErrorMessage ="İsim uzunluğu 50'den fazla olamaz")]
        [MinLength(1,ErrorMessage ="İsim uzunluğu 1'den az olamaz")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Soyisim uzunluğu 50'den fazla olamaz")]
        [MinLength(1, ErrorMessage = "Soyisim uzunluğu 1'den az olamaz")]
        public string LastName { get; set; }

        [Required]
        [Range(10,55, ErrorMessage = "Yaş değerini kontrol ediniz")]
        public string Age { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Milliyet adı uzunluğu 100'den fazla olamaz")]
        [MinLength(1, ErrorMessage = "Milliyet adı uzunluğu 1'den az olamaz")]
        public string Nationality { get; set; }
    }
}

