using MediatR;
using Shop.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Domain.Handlers
{
    public class CreatedCustomerHandler : IRequestHandler<CreatedCustomerRequest, CreatedCustomerResponse>
    {
 
        public Task<CreatedCustomerResponse> Handle(CreatedCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreatedCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Thiago Stteffen",
                Email = "thiagokalu@zzzzz.com",
                Date = DateTime.Now

            };
            return Task.FromResult(result); 
        }
    }
}
