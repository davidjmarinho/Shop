using Shop.Domain.Commands.Responses;
using Shop.Domain.Commands.Requests;
using System;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace Shop.Domain.Handlers
{

    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Verify if the users is already registered.
            //Check the datas
            //Insert the user
            //Send a welcome mail

            if (String.IsNullOrEmpty(request.Name))
            {
                var result = new CreateCustomerResponse
                {
                    Id = Guid.NewGuid(),
                    Name = "David Pereira",
                    Email = "david@email.com",
                    Date = DateTime.Now
                };
                return Task.FromResult(result);

            }
            else
            {
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

    }
}