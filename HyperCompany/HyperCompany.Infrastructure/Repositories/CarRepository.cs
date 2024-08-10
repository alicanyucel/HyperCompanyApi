using GenericRepository;
using HyperCompany.Domain.Entities;
using HyperCompany.Domain.Repositories;

namespace HyperCompany.Infrastructure.Repositories;

internal sealed class CarRepository : Repository<Car, ApplicationDbContext>, ICarRepository
{
    public CarRepository(ApplicationDbContext context) : base(context)
    {

    }
}