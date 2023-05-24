using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using PlayGo.Infrastructure.Attributes;

namespace PlayGo.Areas.Admin.Models.CategoryDTO
{
    public class UpdateCategoryDTO
    {
        public int Id { get; set; }

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
