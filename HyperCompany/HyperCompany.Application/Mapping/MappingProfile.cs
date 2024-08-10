using AutoMapper;
using HyperCompany.Application.Features.Boat.CreateBoat;
using HyperCompany.Domain.Entities;

namespace HyperCompany.Application.Mapping;
public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBoatCommand, Boat>().ReverseMap();
    }
}
