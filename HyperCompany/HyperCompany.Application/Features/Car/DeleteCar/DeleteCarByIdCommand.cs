using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Car.DeleteCar;

public sealed record DeleteCarByIdCommand(
  Guid Id) : IRequest<Result<string>>;