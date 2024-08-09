namespace HyperCompany.Domain.Abstractions;
public abstract class Vehicle
{
    
    public Guid Id { get; set; }
    protected Vehicle()
    {
        Id = Guid.NewGuid();
    }
}
