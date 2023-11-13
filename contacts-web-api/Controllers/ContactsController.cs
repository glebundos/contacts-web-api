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

        [HttpGet]
        public async Task<ActionResult<List<Contact>>> Get()
        {
            return await QueryAsync(new GetAllContactsQuery());
        }
    }
}
