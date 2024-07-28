using System.ComponentModel.DataAnnotations;

namespace Product_Management_Sys.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
