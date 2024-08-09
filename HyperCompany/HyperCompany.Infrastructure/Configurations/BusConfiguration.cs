
using HyperCompany.Domain.Entities;
using HyperCompany.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HyperCompany.Infrastructure.Configurations;

internal sealed class BusConfiguration : IEntityTypeConfiguration<Bus>
{
    public void Configure(EntityTypeBuilder<Bus> builder)
    {
        builder.Property(p => p.Color).HasConversion(v => v.Value, v => VehicleEnum.FromValue(v)).HasColumnName("Color");
    }
}
