using contacts_web_api.Core.Entities;
using contacts_web_api.Core.Repositories;
using contacts_web_api.Infrastructure.Data;
using contacts_web_api.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Infrastructure.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(ContactsContext contactContext) : base(contactContext)
        {
        }
    }
}
