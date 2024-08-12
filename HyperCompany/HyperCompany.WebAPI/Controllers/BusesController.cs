using HyperCompany.Application.Features.Bus.CreateBus;
using HyperCompany.Application.Features.Bus.DeleteBus;
using HyperCompany.Application.Features.Bus.GetAllBus;
using HyperCompany.Application.Features.Bus.UpdateBus;
using HyperCompany.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompany.WebAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
[AllowAnonymous]
public class BusesController : ApiController
{
    public BusesController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateBusCommand request, CancellationToken cancellationToken)
    {

        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);

    }
    [HttpPost]
    public async Task<IActionResult> GetAll(GetBusQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);

    }
    [HttpPost]
    public async Task<IActionResult> DeleteById(DeleteBusByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);

    }
    [HttpPost]
    public async Task<IActionResult> Update(UpdateBusCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);

    }
}
