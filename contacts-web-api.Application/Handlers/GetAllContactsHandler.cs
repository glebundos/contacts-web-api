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
    public class GetAllContactsHandler : IRequestHandler<GetAllContactsQuery, List<Contact>>
    {
        private readonly IContactRepository _contactRepo;

        public GetAllContactsHandler(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public async Task<List<Contact>> Handle(GetAllContactsQuery request, CancellationToken cancellationToken)
        {
            var contacts = (List<Contact>)await _contactRepo.GetAllAsync();
            contacts = contacts.OrderBy(x => x.Name).ToList();
            return contacts;
        }
    }
}
