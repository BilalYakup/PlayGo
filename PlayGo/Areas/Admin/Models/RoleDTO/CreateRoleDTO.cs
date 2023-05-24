using System.ComponentModel.DataAnnotations;

namespace PlayGo.Areas.Admin.Models.RoleDTO
{
    public class CreateRoleDTO
    {
        [Required, MinLength(3, ErrorMessage = "en az 3 karakter giriniz")]
        public string Name { get; set; }
    }
}
