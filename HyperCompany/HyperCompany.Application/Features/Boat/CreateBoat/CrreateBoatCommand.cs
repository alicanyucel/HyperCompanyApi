

using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boat.CreateBoat;

public sealed record CrreateBoatCommand():IRequest<Result<string>>;

