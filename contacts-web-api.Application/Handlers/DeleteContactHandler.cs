using contacts_web_api.Application.Commands;
using contacts_web_api.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Application.Handlers
{
    public class DeleteContactHandler : IRequestHandler<DeleteContactCommand, Guid>
    {
        private readonly IContactRepository _contactRepo;

        public DeleteContactHandler(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public async Task<Guid> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _contactRepo.GetByIdAsync(request.Id);

            if (contact == null)
            {
                throw new Exception(message: "Contact not found");
            }

            await _contactRepo.DeleteAsync(contact);
            return contact.Id;
        }
    }
}
