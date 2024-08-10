using GenericRepository;
using HyperCompany.Domain.Entities;
using HyperCompany.Domain.Repositories;
using HyperCompany.Infrastructure.Context;

namespace HyperCompany.Infrastructure.Repositories;

internal sealed class BoatRepository : Repository<Boat, ApplicationDbContext>, IBoatRepository
{
    public BoatRepository(ApplicationDbContext context) : base(context)
    {

    }
}
