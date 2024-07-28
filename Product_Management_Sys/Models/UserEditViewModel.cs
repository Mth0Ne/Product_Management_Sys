using System.ComponentModel.DataAnnotations;

namespace Product_Management_Sys.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "İsim boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soy İsim boş geçilemez")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Mail boş geçilemez")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Cinsiyet Seçiniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez")]
        [Compare("Password", ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        public string ConfirmPassword { get; set; }
    }
}
