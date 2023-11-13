using contacts_web_api.Core.Entities;
using contacts_web_api.Core.Repositories;
using contacts_web_api.Infrastructure.Data;
using contacts_web_api.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Infrastructure.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(ContactsContext contactContext) : base(contactContext)
        {
        }

        public override async Task<IReadOnlyList<Contact>> GetAllAsync()
        {
            return await _contactContext.Set<Contact>()
                .Include(x => x.Job)
                .ToListAsync();
        }
    }
}
