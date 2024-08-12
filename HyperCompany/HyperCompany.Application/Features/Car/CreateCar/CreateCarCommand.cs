
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Car.CreateCar;
public sealed record CreateCarCommand(Guid BoatId, bool IsHeadLightActive, string Tire, string HeadLight, int ColorValue) : IRequest<Result<string>>;


