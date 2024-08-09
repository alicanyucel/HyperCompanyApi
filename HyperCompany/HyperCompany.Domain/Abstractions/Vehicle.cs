using HyperCompany.Domain.Enums;

namespace HyperCompany.Domain.Abstractions;
public abstract class Vehicle
{

    public Guid Id { get; set; }

    public required VehicleEnum Color { get; set; }

}
