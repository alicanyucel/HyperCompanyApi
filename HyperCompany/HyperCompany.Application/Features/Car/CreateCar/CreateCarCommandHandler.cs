using AutoMapper;
using GenericRepository;
using HyperCompany.Application.Features.Bus.CreateBus;
using HyperCompany.Domain.Repositories;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Car.CreateCar;

internal sealed class CreateCarComamndHandler(ICarRepository carRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateCarCommand, Result<string>>
{
    public ICarRepository CarRepository { get; } = carRepository;
    

    public async Task<Result<string>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
    {
        HyperCompany.Domain.Entities.Car car = mapper.Map<HyperCompany.Domain.Entities.Car>(request);

        await CarRepository.AddAsync(car, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Car Added";
    }
}