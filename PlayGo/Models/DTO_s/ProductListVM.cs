using PlayGo.Models.Abstract;

namespace PlayGo.Models.DTO_s
{
    public class ProductListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
    }
}
