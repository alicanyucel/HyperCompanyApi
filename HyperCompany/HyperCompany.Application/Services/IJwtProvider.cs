using HyperCompany.Application.Features.Auth.Login;
using HyperCompany.Domain.Entities;

namespace HyperCompany.Application.Services;
public interface IJwtProvider
{
    Task<LoginCommandResponse> CreateToken(AppUser user);
}
