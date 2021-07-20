using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain;
using Shop.Domain.Handlers;
using Shop.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("v1/customers")]
        public Task<CreatedCustomerResponse> Created(
            [FromServices]IMediator mediator,
            [FromBody]  CreatedCustomerRequest command

         ){
            return mediator.Send(command);
        }
    }
}
