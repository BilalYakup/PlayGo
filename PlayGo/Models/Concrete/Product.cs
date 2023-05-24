using PlayGo.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayGo.Models.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string Image { get; set; }

        
        [NotMapped]
        public IFormFile UploadImage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
