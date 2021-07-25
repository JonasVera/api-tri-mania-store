using Api.Domain.Dtos.Product;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<UserDtoCreateResult, User>().ReverseMap();

            CreateMap<AddressDto, Address>().ReverseMap();

            CreateMap<CategoryDto, Category>().ReverseMap();

            CreateMap<ProductDto, Product>().ReverseMap();
        }
    }
}
