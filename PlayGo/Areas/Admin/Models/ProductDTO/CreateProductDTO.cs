using PlayGo.Infrastructure.Attributes;
using PlayGo.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayGo.Areas.Admin.Models.ProductDTO
{
    public class CreateProductDTO
    {
        [Required(ErrorMessage = "Lütfen bir isim giriniz!!")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lütfen bir açıklama giriniz!!")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Lütfen bir fiyat giriniz!!")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal UnitPrice { get; set; }


        public string? Image { get; set; }

        [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        public IFormFile UploadImage { get; set; }


        [Required(ErrorMessage = "Lütfen bir kategori seçiniz!!")]
        public int CategoryId { get; set; }
    }
}
