using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Bus.DeleteBus;

public sealed record DeleteBusByIdCommand(
    Guid Id) : IRequest<Result<string>>;