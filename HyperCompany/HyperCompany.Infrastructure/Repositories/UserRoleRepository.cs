using GenericRepository;
using HyperCompany.Domain.Entities;
using HyperCompany.Domain.Repositories;
using HyperCompany.Infrastructure.Context;

namespace HyperCompany.Infrastructure.Repositories;
internal sealed class UserRoleRepository : Repository<AppUserRole, ApplicationDbContext>, IUserRoleRepository
{
    public UserRoleRepository(ApplicationDbContext context) : base(context)
    {
    }
}