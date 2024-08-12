using AutoMapper;
using HyperCompany.Application.Features.Boat.CreateBoat;
using HyperCompany.Application.Features.Boats.UpdateBoat;
using HyperCompany.Application.Features.Bus.CreateBus;
using HyperCompany.Application.Features.Bus.UpdateBus;
using HyperCompany.Application.Features.Car.CreateCar;
using HyperCompany.Domain.Entities;
using HyperCompany.Domain.Enums;

namespace HyperCompany.Application.Mapping;
public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreatBoatCommand,Boat>().ForMember(member => member.Color, options =>
        {
            options.MapFrom(map => VehicleEnum.FromValue(map.ColorValue));
        });
        CreateMap<CreateCarCommand, Car>().ForMember(member => member.Color, options =>
        {
            options.MapFrom(map => VehicleEnum.FromValue(map.ColorValue));
        });
        CreateMap<CreateBusCommand, Bus>().ForMember(member => member.Color, options =>
        {
            options.MapFrom(map => VehicleEnum.FromValue(map.ColorValue));
        });
        CreateMap<CreatBoatCommand, Boat>().ReverseMap();
        CreateMap<CreateBusCommand ,Bus>().ReverseMap();
        CreateMap<CreateCarCommand, Car>().ReverseMap();
        CreateMap<UpdateBoatCommand, Boat>().ReverseMap();
        CreateMap<UpdateBusCommand, Bus>().ReverseMap();
    }
}
