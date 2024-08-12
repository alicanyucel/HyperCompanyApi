using HyperCompany.Domain.Enums;

namespace HyperCompany.Domain.Abstractions;
public abstract class Vehicle
{
    public bool IsHeadlightActive { get; set; }
    public string Tire { get; set; } = default!;
    public string Headlight { get; set; } = default!;
    public Guid Id { get; set; }
    public VehicleEnum Color { get; set; } = VehicleEnum.Purple; 
  
    protected Vehicle()
    {
        Id = Guid.NewGuid();
    }
}
