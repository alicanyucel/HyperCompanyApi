using GenericRepository;
using HyperCompany.Domain.Repositories;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boats.DeleteBoatById;

internal sealed class DeleteBoatByIdCommandHandler(
    IBoatRepository boatRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<UpdateBoatByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateBoatByIdCommand request, CancellationToken cancellationToken)
    {
        HyperCompany.Domain.Entities.Boat? boat = await boatRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);
        if (boat is null)
        {
            return Result<string>.Failure("Boat not found");
        }

        boatRepository.Delete(boat);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Boat delete is successful";
    }
}


