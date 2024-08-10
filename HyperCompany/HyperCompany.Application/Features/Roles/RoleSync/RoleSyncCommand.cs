

using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Roles.RoleSync;

public sealed record RoleSyncCommand() : IRequest<Result<string>>;