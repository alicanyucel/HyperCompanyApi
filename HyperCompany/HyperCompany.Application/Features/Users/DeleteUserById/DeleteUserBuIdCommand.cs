using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Users.DeleteUserById;

public sealed record DeleteUserByIdCommand(
  Guid Id) : IRequest<Result<string>>;