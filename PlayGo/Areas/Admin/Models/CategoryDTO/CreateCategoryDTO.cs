using PlayGo.Infrastructure.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlayGo.Areas.Admin.Models.CategoryDTO
{
    public class CreateCategoryDTO
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        [MinLength(3, ErrorMessage = "En az 3 karakter girmelisiniz!")]
        [RegularExpression(@"^[a-zA-Z- ]+$", ErrorMessage = "Sadece harflere izin veriliyor!!")]
        public string Name { get; set; }

        public string? Image { get; set; }

        [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        public IFormFile UploadImage { get; set; }
    }
}
