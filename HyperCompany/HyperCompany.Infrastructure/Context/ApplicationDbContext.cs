using HyperCompany.Domain.Entities;
using GenericRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HyperCompany.Infrastructure.Context;
internal sealed class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid, IdentityUserClaim<Guid>, AppUserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Bus> Buses { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Boat> Boats { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Ignore<IdentityUserClaim<Guid>>();
        builder.Ignore<IdentityRoleClaim<Guid>>();
        builder.Ignore<IdentityUserLogin<Guid>>();
        builder.Ignore<IdentityUserToken<Guid>>();
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


    }
}
