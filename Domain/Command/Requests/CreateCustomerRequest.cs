using CQRSMediator.Domain.Commands.Responses;
using MediatR;

namespace CQRSMediator.Domain.Commands.Requests;

public class CreateCustomerRequest: IRequest<CreateCustomerResponse>
{
    public string Name { get; set; }
    public string Email { get; set; }
}
