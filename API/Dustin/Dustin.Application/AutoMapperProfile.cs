using AutoMapper;
using Dustin.Application.DTOs;
using Dustin.Domain.Entities;

namespace Dustin.Application
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<ProductItemDTO, ProductItem>().ReverseMap();
            CreateMap<ProductItemSubFeatureDTO, ProductItemSubFeature>().ReverseMap();
            CreateMap<BrandDTO, Brand>().ReverseMap();
            CreateMap<FeatureDTO, Feature>().ReverseMap();
            CreateMap<SubFeatureDTO, SubFeature>().ReverseMap();
            CreateMap<CategoryDTO, Category>().ReverseMap();
            CreateMap<SubCategoryDTO, SubCategory>().ReverseMap();

            CreateMap<CreateProductDTO, Product>()
           .ForMember(dest => dest.ProductItems, opt => opt.MapFrom(src => src.ProductItems));

            CreateMap<CreateProductItemDTO, ProductItem>()
                .ForMember(dest => dest.ProductItemSubFeatures, opt => opt.MapFrom(src => src.SubFeatures));

            CreateMap<CreateProductSubFeatureDTO, ProductItemSubFeature>()
                .ForMember(dest => dest.SubFeatureId, opt => opt.MapFrom(src => src.Id));

            CreateMap<UpdateProductDTO, Product>()
                .ForMember(dest => dest.ProductItems, opt => opt.MapFrom(src => src.ProductItems));

            CreateMap<UpdateProductItemDTO, ProductItem>()
                .ForMember(dest => dest.ProductItemSubFeatures, opt => opt.MapFrom(src => src.SubFeatures));
        }
    }
}