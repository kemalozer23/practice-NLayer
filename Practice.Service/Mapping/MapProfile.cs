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
            CreateMap<ProductFeatureDto, ProductFeature>();
        }
    }
}