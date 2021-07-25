using Api.Domain.Dtos.Product;
using Api.Domain.Dtos.User; 
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        { 
           CreateMap<UserModel, UserDto>().ReverseMap();
           CreateMap<UserModel, UserDtoCreate>().ReverseMap();
           CreateMap<UserModel, UserDtoUpdate>().ReverseMap();
           CreateMap<AddressModel, AddressDto>().ReverseMap();
            // CATEGORY
           CreateMap<CategoryModel, CategoryDto>().ReverseMap();
            //PRODUCT
            CreateMap<ProductModel, ProductDto>().ReverseMap();
        }
    }
}
