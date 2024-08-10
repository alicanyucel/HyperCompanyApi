

using AutoMapper;
using GenericRepository;
using HyperCompany.Application.Features.Boat.CreateBoat;
using HyperCompany.Domain.Repositories;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Boats.CreateBoat;

internal sealed class CreateBoatComamndHandler(IBoatRepository boatRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateBoatCommand, Result<string>>
{
    public IBoatRepository BoatRepository { get; } = boatRepository;

    public async Task<Result<string>> Handle(CreateBoatCommand request, CancellationToken cancellationToken)
    {
        HyperCompany.Domain.Entities.Boat boat = mapper.Map<HyperCompany.Domain.Entities.Boat>(request);

        await BoatRepository.AddAsync(boat, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Boat Added";
    }
}
