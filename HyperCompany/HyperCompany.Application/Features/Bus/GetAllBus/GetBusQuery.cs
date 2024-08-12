

using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Bus.GetAllBus;

public sealed record GetBusQuery() : IRequest<Result<List<HyperCompany.Domain.Entities.Bus>>>;
