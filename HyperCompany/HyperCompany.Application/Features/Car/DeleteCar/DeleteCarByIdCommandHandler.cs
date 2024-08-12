using GenericRepository;
using HyperCompany.Domain.Repositories;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Car.DeleteCar;
internal sealed class DeleteCarByIdCommandHandler(
 ICarRepository carRepository,
 IUnitOfWork unitOfWork) : IRequestHandler<DeleteCarByIdCommand, Result<string>>
{
   
    public async Task<Result<string>> Handle(DeleteCarByIdCommand request, CancellationToken cancellationToken)
    {
        HyperCompany.Domain.Entities.Car? car = await carRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);
        if (car is null)
        {
            return Result<string>.Failure("Car not found");
        }

        carRepository.Delete(car);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Car delete is successful";
    }
}