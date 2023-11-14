using contacts_web_api.Application.Commands;
using contacts_web_api.Application.Mappers;
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
    public class CreateContactHandler : IRequestHandler<CreateContactCommand, Guid>
    {
        private readonly IContactRepository _contactRepo;

        public CreateContactHandler(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public async Task<Guid> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var contactEntity = ContactMapper.Mapper.Map<Contact>(request);

            if (contactEntity == null)
            {
                throw new Exception(message: "Invalid request");
            }

            return (await _contactRepo.AddAsync(contactEntity)).Id;
        }
    }
}
