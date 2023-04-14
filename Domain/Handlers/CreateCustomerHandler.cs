using CQRSMediator.Domain.Commands.Requests;
using CQRSMediator.Domain.Commands.Responses;
using MediatR;

namespace CQRSMediator.Domain.Commands.Handlers;
public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
{
    public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        //verifica se o cliente já está cadastrado
        //valida os dados
        //insere o cliente
        //envia email de boas vindas
        var result = new CreateCustomerResponse
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Email = request.Email,
            Date = DateTime.Now
        };

        return Task.FromResult(result);
    }
}