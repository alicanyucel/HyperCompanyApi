
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Bus.CreateBus;

public sealed record CreateBusCommand(Guid BoatId, bool IsHeadLightActive, string Tire, string HeadLight, int ColorValue) : IRequest<Result<string>>;