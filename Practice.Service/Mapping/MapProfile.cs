using AutoMapper;
using Practice.Core.DTOs;
using Practice.Core.Models;

namespace Practice.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductUpdateDto>();
            // CreateMap<Product, ProductWithCategoryDto>();
            // CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}