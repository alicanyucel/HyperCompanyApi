using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boats.UpdateBoat;
public sealed record UpdateBoatCommand(Guid BoatId, bool IsHeadLightActive, string Tire, string HeadLight, int ColorValue) : IRequest<Result<string>>;