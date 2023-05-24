using PlayGo.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayGo.Models.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile UploadImage { get; set; }
        public List<Product> Products { get; set; }
    }
}
