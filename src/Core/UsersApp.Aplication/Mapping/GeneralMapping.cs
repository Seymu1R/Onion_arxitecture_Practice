using AutoMapper;
using UsersApp.Aplication.Dtos;
using UsersApp.Aplication.Features.Commads;
using UsersApp.Aplication.Features.Queries.GetUsers.GetProductById;
using UsersApp.Domain.Entities;

namespace UsersApp.Aplication.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<User, UserViewDto>()
                .ReverseMap();
            CreateMap<User, CreateUserComand>()
                .ReverseMap();
            CreateMap<User, GetUserByIdQueryViewDto>()
                .ReverseMap();
        }
    }
}
