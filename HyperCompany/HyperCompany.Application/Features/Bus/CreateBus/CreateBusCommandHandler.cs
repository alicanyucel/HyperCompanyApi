using AutoMapper;
using GenericRepository;
using HyperCompany.Domain.Repositories;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Bus.CreateBus;

internal sealed class CreateBusComamndHandler(IBusRepository busRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateBusCommand, Result<string>>
{
    public IBusRepository BusRepository { get; } = busRepository;
    public async Task<Result<string>> Handle(CreateBusCommand request, CancellationToken cancellationToken)
    {
        HyperCompany.Domain.Entities.Bus bus = mapper.Map<HyperCompany.Domain.Entities.Bus>(request);

        await BusRepository.AddAsync(bus, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Bus Added";
    }
}