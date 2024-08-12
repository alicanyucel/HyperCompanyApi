

using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boats.GetAllBoat;

public sealed record GetBoatsQuery() : IRequest<Result<List<HyperCompany.Domain.Entities.Boat>>>;