using AutoMapper;
using Mine.Commerce.Domain;

namespace Mine.Commerce.Application.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateRequest, Product>();
            CreateMap<UpdateRequest, Product>();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryDto>().ReverseMap();
            CreateMap<ProductImage, ProductImageDto>().ReverseMap();
        }
    }
}