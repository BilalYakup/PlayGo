using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using PlayGo.Models.Concrete;

namespace PlayGo.Models.DTO_s.UserDTO
{
    public class UpdateUserDTO
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur!!")]
        [DisplayName("Kullanıcı Adı")]
        [MinLength(3, ErrorMessage = "En az 3 karakter girmelisiniz!!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email adresi zorunludur!!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Emailinizi doğru formatta giriniz!!")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur!!")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public UpdateUserDTO() { }
        public UpdateUserDTO(AppUser user)
        {
            UserName= user.UserName;
            Email= user.Email;
            Password = user.PasswordHash;
        }

        
    }
}
