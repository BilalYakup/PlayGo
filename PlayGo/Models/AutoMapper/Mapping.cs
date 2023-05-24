using PlayGo.Models.Concrete;
using AutoMapper;
using PlayGo.Areas.Admin.Models.CategoryDTO;
using PlayGo.Areas.Admin.Models.ProductDTO;

namespace AsenkronProgramlama.Models.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
           
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>();


            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();

            //CreateMap<UpdateCategoryDTO, Category>().ReverseMap();


            //CreateMap<Category, CreateCategoryDTO>();
            //CreateMap<CreateCategoryDTO, Category>().ReverseMap();
        }
    }
}
