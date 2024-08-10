

using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boat.CreateBoat;

public sealed record CreateBoatCommand(Guid BoatId,string Tire,string HeadLight,int Color):IRequest<Result<string>>;

