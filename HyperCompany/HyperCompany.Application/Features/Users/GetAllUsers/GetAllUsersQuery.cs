using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Users.GetAllUsers;
public sealed record GetAllUsersQuery() : IRequest<Result<List<GetAllUsersQueryResponse>>>;