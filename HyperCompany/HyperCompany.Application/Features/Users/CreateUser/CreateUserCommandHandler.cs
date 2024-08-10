using GenericRepository;
using HyperCompany.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TS.Result;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using HyperCompany.Domain.Repositories;
namespace HyperCompany.Application.Features.Users.CreateUser;

internal sealed class CreateUserCommandHandler(
    UserManager<AppUser> userManager,
    IUserRoleRepository userRoleRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateUserCommand, Result<string>>
{
    private readonly UserManager<AppUser> userManager = userManager;
    private readonly IUserRoleRepository userRoleRepository = userRoleRepository;
    private readonly IUnitOfWork unitOfWork = unitOfWork;
    private readonly IMapper mapper = mapper;

    public async Task<Result<string>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        if (await userManager.Users.AnyAsync(p => p.Email == request.Email))
        {
            return Result<string>.Failure("Email already exists");
        }

        if (await userManager.Users.AnyAsync(p => p.UserName == request.UserName))
        {
            return Result<string>.Failure("User name already exists");
        }

        AppUser user = mapper.Map<AppUser>(request);
        IdentityResult result = await userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            return Result<string>.Failure(result.Errors.Select(s => s.Description).ToList());
        }


        if (request.RoleIds.Any())
        {
            List<AppUserRole> userRoles = new();
            foreach (var roleId in request.RoleIds)
            {
                AppUserRole userRole = new()
                {
                    RoleId = roleId,
                    UserId = user.Id
                };
                userRoles.Add(userRole);
            }

            await userRoleRepository.AddRangeAsync(userRoles, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        return "User create is successful";
    }
}