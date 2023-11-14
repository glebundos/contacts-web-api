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
    public class JobsController : ApiControllerBase
    {
        public JobsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<Job>>> Get()
        {
            return await QueryAsync(new GetAllJobsQuery());
        }
    }
}
