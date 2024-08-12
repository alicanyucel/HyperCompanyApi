using HyperCompany.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace HyperCompany.Application.Features.Bus.GetAllBus;

internal sealed class GetAllBusQueryHandler(IBusRepository busRepository) : IRequestHandler<GetBusQuery, Result<List<HyperCompany.Domain.Entities.Bus>>>
{
    public async Task<Result<List<Domain.Entities.Bus>>> Handle(GetBusQuery request, CancellationToken cancellationToken)
    {
        List<HyperCompany.Domain.Entities.Bus> bus = await busRepository.GetAll().ToListAsync(cancellationToken);

        return bus;
    }
}