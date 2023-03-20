using AutoMapper;
using Domain.DTOs.Request;
using Domain.Models;

namespace API.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductRequest, Product>()
                .ForMember(dest => dest.ProductName, map =>
                    map.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.Description, map =>
                    map.MapFrom(src => src.Description));
        }
    }
}
