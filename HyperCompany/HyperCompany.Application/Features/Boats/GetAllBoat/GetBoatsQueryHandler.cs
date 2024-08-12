
using HyperCompany.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace HyperCompany.Application.Features.Boats.GetAllBoat;

internal sealed class GetAllBoatQueryHandler(IBoatRepository boatRepository) : IRequestHandler<GetBoatsQuery, Result<List<HyperCompany.Domain.Entities.Boat>>>
{
    public async Task<Result<List<HyperCompany.Domain.Entities.Boat>>> Handle(GetBoatsQuery request, CancellationToken cancellationToken)
    {
        List<HyperCompany.Domain.Entities.Boat> boats = await boatRepository.GetAll().ToListAsync(cancellationToken);

        return boats;
    }
}