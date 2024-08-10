using GenericRepository;
using HyperCompany.Domain.Entities;
using HyperCompany.Domain.Repositories;

namespace HyperCompany.Infrastructure.Repositories;

internal sealed class BusRepository : Repository<Bus, ApplicationDbContext>, IBusRepository
{
    public BusRepository(ApplicationDbContext context) : base(context)
    {

    }
}