using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<User, UserModel>().ReverseMap();

            CreateMap<Address, AddressModel>().ReverseMap();
            
            CreateMap<CategoryModel, Category>().ReverseMap();

            CreateMap<ProductModel, Product>().ReverseMap();
        }
    }
}
