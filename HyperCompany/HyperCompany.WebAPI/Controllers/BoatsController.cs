
using HyperCompany.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompany.WebAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BoatsController : ApiController
{
    public BoatsController(IMediator mediator) : base(mediator)
    {
    }
}

