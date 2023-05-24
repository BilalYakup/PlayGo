using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlayGo.Models.DTO_s.UserDTO
{
    public class RegisterDTO
    {
       [Required(ErrorMessage ="bu alan zorunlu")]
       [DisplayName("kullanıcı adı")]
       [MinLength(3,ErrorMessage ="en az 3 karakter giriniz")]
       public string UserName { get; set; }

        [Required(ErrorMessage = "bu alan zorunlu")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress,ErrorMessage ="lütfen doğru formatta giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "bu alan zorunlu")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
