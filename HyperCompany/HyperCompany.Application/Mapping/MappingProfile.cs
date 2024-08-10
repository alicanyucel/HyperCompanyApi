using AutoMapper;
using HyperCompany.Application.Features.Users.CreateUser;
using HyperCompany.Application.Features.Users.UpdateUser;
using HyperCompany.Domain.Entities;


namespace HyperCompany.Application.Mapping;
public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUserCommand, AppUser>().ReverseMap();
        CreateMap<UpdateUserCommand, AppUser>().ReverseMap();
    }
}
