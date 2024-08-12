
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boats.DeleteBoatById;

public sealed record UpdateBoatByIdCommand(
    Guid Id) : IRequest<Result<string>>;