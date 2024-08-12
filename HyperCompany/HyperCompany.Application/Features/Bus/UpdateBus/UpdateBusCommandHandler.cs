using AutoMapper;
using GenericRepository;
using HyperCompany.Domain.Repositories;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Bus.UpdateBus;

internal sealed class UpdateBusCommandHandler(IBusRepository busRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdateBusCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateBusCommand request, CancellationToken cancellationToken)
    {
        HyperCompany.Domain.Entities.Bus? bus = await busRepository.GetByExpressionWithTrackingAsync(P => P.Id == request.BusId, cancellationToken);
        if (bus == null)
        {
            return Result<string>.Failure("bus not found");
        }
        mapper.Map(request, bus);
        busRepository.Update(bus);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Bus update is successful";
    }
}