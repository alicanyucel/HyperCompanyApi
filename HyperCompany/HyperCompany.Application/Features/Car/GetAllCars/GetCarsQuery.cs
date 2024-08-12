using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Car.GetAllCars;

public sealed record GetCarQuery() : IRequest<Result<List<HyperCompany.Domain.Entities.Car>>>;