using HyperCompany.Application.Features.Auth.Login;
using HyperCompany.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompany.WebAPI.Controllers;
[AllowAnonymous]
public sealed class AuthsController : ApiController
{
/*
   {
    "emailOrUserName": "admin",
    "password": "1"
   } yazarak auth controllerden token alabilirsiniz
    
 */
    public AuthsController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginCommand request, CancellationToken cancellationToken)
    {        
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
