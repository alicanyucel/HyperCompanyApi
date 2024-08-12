

using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boat.CreateBoat;

public sealed record CreatBoatCommand(Guid BoatId,bool IsHeadLightActive,string Tire,string HeadLight,int ColorValue):IRequest<Result<string>>;

