using HyperCompany.Application.Features.Users.CreateUser;
using HyperCompany.Application.Features.Users.DeleteUserById;
using HyperCompany.Application.Features.Users.GetAllRolesForUsers;
using HyperCompany.Application.Features.Users.GetAllUsers;
using HyperCompany.Application.Features.Users.UpdateUser;
using HyperCompany.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompany.WebAPI.Controllers
{
    namespace EAppointment.WebApi.Controllers
    {
        public sealed class UsersController : ApiController
        {
            public UsersController(IMediator mediator) : base(mediator)
            {
            }

            [HttpPost]
            public async Task<IActionResult> GetAll(GetAllUsersQuery request, CancellationToken cancellationToken)
            {
                var response = await _mediator.Send(request, cancellationToken);
                return StatusCode(response.StatusCode, response);
            }

            [HttpPost]
            public async Task<IActionResult> GetAllRoles(GetAllRolesForUsersQuery request, CancellationToken cancellationToken)
            {
                var response = await _mediator.Send(request, cancellationToken);
                return StatusCode(response.StatusCode, response);
            }

            [HttpPost]
            public async Task<IActionResult> Create(CreateUserCommand request, CancellationToken cancellationToken)
            {
                var response = await _mediator.Send(request, cancellationToken);
                return StatusCode(response.StatusCode, response);
            }

            [HttpPost]
            public async Task<IActionResult> DeleteById(DeleteUserByIdCommand request, CancellationToken cancellationToken)
            {
                var response = await _mediator.Send(request, cancellationToken);
                return StatusCode(response.StatusCode, response);
            }

            [HttpPost]
            public async Task<IActionResult> Update(UpdateUserCommand request, CancellationToken cancellationToken)
            {
                var response = await _mediator.Send(request, cancellationToken);
                return StatusCode(response.StatusCode, response);
            }
        }
    }
}
