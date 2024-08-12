
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boats.DeleteBoatById;

public sealed record DeleteBoatByIdCommand(
    Guid Id) : IRequest<Result<string>>;