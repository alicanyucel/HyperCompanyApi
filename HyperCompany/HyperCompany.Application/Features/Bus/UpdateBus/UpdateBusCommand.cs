

using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Bus.UpdateBus;

public sealed record UpdateBusCommand(Guid BusId, bool IsHeadLightActive, string Tire, string HeadLight, int ColorValue) : IRequest<Result<string>>;