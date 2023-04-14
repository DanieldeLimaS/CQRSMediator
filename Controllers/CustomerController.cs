using CQRSMediator.Domain.Commands.Requests;
using CQRSMediator.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediator.Controllers;
[ApiController]
[Route("customers")]
public class CustomerController : ControllerBase
{
    [HttpPost]
    [Route("")]
    public Task<CreateCustomerResponse> Create(
        [FromServices] IMediator mediator,
        [FromBody] CreateCustomerRequest command)
    {
        return mediator.Send(command);
    }

}