using GenericRepository;
using HyperCompany.Domain.Entities;
using HyperCompany.Domain.Repositories;

namespace HyperCompany.Infrastructure.Repositories;
internal sealed class UserRoleRepository : Repository<AppUserRole, ApplicationDbContext>, IUserRoleRepository
{
    public UserRoleRepository(ApplicationDbContext context) : base(context)
    {
    }
}