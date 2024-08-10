
using HyperCompany.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompany.WebAPI.Controllers;


public class BusesController : ApiController
{
    public BusesController(IMediator mediator) : base(mediator)
    {
    }
}
