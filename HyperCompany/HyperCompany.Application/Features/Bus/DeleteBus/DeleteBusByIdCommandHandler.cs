using GenericRepository;
using HyperCompany.Domain.Repositories;
using MediatR;
using TS.Result;

namespace HyperCompany.Application.Features.Bus.DeleteBus;
internal sealed class DeleteBusByIdCommandHandler(
 IBusRepository busRepository,
 IUnitOfWork unitOfWork) : IRequestHandler<DeleteBusByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteBusByIdCommand request, CancellationToken cancellationToken)
    {
        HyperCompany.Domain.Entities.Bus? bus = await busRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);
        if (bus is null)
        {
            return Result<string>.Failure("Boat not found");
        }

        busRepository.Delete(bus);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Bus delete is successful";
    }
}