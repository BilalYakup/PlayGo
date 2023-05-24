using PlayGo.Models.Abstract;

namespace PlayGo.Areas.Admin.Models.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
        public string CategoryName { get; set; }
    }
}
