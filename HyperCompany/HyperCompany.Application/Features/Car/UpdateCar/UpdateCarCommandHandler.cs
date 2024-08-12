using AutoMapper;
using GenericRepository;
using HyperCompany.Domain.Repositories;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Car.UpdateCar;

internal sealed class UpdateCarCommandHandler(ICarRepository carRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdateCarCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
    {
        HyperCompany.Domain.Entities.Car? car = await carRepository.GetByExpressionWithTrackingAsync(P => P.Id == request.BusId, cancellationToken);
        if (car == null)
        {
            return Result<string>.Failure("car not found");
        }
        mapper.Map(request, car);
        carRepository.Update(car);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Car update is successful";
    }
}
