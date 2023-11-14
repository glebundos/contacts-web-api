using contacts_web_api.Application.Commands;
using contacts_web_api.Application.Queries;
using contacts_web_api.Controllers.Base;
using contacts_web_api.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace contacts_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ApiControllerBase
    {
        public ContactsController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateContactCommand command)
        {
            return await CommandAsync(command);
        }

        [HttpGet]
        public async Task<ActionResult<List<Contact>>> Get()
        {
            return await QueryAsync(new GetAllContactsQuery());
        }

        [HttpPut]
        public async Task<ActionResult<Contact>> Update([FromBody] UpdateContactCommand command)
        {
            return await CommandAsync(command);
        }

        [HttpDelete]
        public async Task<ActionResult<Guid>> Delete([FromBody] DeleteContactCommand command)
        {
            return await QueryAsync(command);
        }
    }
}
