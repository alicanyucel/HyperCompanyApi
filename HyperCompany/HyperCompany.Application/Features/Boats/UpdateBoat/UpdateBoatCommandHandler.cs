using AutoMapper;
using GenericRepository;
using HyperCompany.Domain.Repositories;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boats.UpdateBoat;

internal sealed class UpdateBoatCommandHandler(IBoatRepository boatRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdateBoatCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateBoatCommand request, CancellationToken cancellationToken)
    {
        HyperCompany.Domain.Entities.Boat? boat = await boatRepository.GetByExpressionWithTrackingAsync(P => P.Id == request.BoatId, cancellationToken);
        if (boat == null)
        {
            return Result<string>.Failure("boat not found");
        }
        mapper.Map(request, boat);
        boatRepository.Update(boat);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Boat update is successful";

    }
}
