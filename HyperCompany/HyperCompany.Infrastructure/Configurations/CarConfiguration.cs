
using HyperCompany.Domain.Entities;
using HyperCompany.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HyperCompany.Infrastructure.Configurations;

internal sealed class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.Property(p => p.Color).HasConversion(v => v.Value, v => VehicleEnum.FromValue(v)).HasColumnName("Color");
    }
}
