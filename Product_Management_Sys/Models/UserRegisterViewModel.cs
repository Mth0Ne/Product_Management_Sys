using System.ComponentModel.DataAnnotations;

namespace Product_Management_Sys.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "İsim boş geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soy İsim boş geçilemez")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Mail boş geçilemez")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        [Compare("Password",ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        public string Passworda { get; set; }

    }
}
