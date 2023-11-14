using contacts_web_api.Application.Queries;
using contacts_web_api.Core.Entities;
using contacts_web_api.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Application.Handlers
{
    public class GetAllJobsHandler : IRequestHandler<GetAllJobsQuery, List<Job>>
    {
        private readonly IJobRepository _jobRepo;

        public GetAllJobsHandler(IJobRepository jobRepo)
        {
            _jobRepo = jobRepo;
        }

        public async Task<List<Job>> Handle(GetAllJobsQuery request, CancellationToken cancellationToken)
        {
            var jobs = (List<Job>)await _jobRepo.GetAllAsync();

            return jobs;
        }
    }
}
