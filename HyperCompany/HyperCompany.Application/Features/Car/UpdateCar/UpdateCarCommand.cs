using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Car.UpdateCar;
public sealed record UpdateCarCommand(Guid BusId, bool IsHeadLightActive, string Tire, string HeadLight, int ColorValue) : IRequest<Result<string>>;
