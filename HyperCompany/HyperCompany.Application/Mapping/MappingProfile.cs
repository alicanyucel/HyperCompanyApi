using AutoMapper;
using HyperCompany.Application.Features.Boat.CreateBoat;
using HyperCompany.Domain.Entities;
using HyperCompany.Domain.Enums;

namespace HyperCompany.Application.Mapping;
public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBoatCommand,Boat>().ForMember(member => member.Color, options =>
        {
            options.MapFrom(map => VehicleEnum.FromValue(map.ColorValue));
        });
        CreateMap<CreateBoatCommand, Boat>().ReverseMap();
    }
}
