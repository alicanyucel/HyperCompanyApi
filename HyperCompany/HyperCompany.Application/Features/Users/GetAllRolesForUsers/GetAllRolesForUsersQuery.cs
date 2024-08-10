
using HyperCompany.Domain.Entities;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Users.GetAllRolesForUsers;

public sealed record GetAllRolesForUsersQuery() : IRequest<Result<List<AppRole>>>;