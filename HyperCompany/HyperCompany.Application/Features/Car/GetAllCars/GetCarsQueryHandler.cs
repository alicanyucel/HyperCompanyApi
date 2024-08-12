using HyperCompany.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;
namespace HyperCompany.Application.Features.Car.GetAllCars;

internal sealed class GetAllCarQueryHandler(ICarRepository carRepository) : IRequestHandler<GetCarQuery, Result<List<HyperCompany.Domain.Entities.Car>>>
{
    public async Task<Result<List<Domain.Entities.Car>>> Handle(GetCarQuery request, CancellationToken cancellationToken)
    {
        List<HyperCompany.Domain.Entities.Car> car = await carRepository.GetAll().ToListAsync(cancellationToken);

        return car;
    }
}

