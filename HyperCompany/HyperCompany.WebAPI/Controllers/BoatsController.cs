using HyperCompany.Application.Features.Boat.CreateBoat;
using HyperCompany.Application.Features.Boats.DeleteBoatById;
using HyperCompany.Application.Features.Boats.GetAllBoat;
using HyperCompany.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompany.WebAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
[AllowAnonymous]
public class BoatsController : ApiController
{
  
    public BoatsController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreatBoatCommand request, CancellationToken cancellationToken)
    {
        
        var response = await _mediator.Send(request,cancellationToken);
        return StatusCode(response.StatusCode, response);

    }
    [HttpPost]
    public async Task<IActionResult> GetAll(GetBoatsQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);

    }
    [HttpPost]
    public async Task<IActionResult> DeleteById(UpdateBoatByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    [HttpPost]
    public async Task<IActionResult> UpdateById(UpdateBoatByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

}

