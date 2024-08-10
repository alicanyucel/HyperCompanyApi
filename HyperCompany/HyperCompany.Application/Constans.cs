

using HyperCompany.Application.Features.Roles.RoleSync.EAppointment.Application.Features.Roles.RoleSync;

namespace HyperCompany.Application;

public static class Constants
{
    public static List<AppRole> GetRoles()
    {
        List<string> roles = new()
        {
            "Admin",
            "User",
            "Personel",
        };

        return roles.Select(s => new AppRole() { Name = s }).ToList();
    }
}
