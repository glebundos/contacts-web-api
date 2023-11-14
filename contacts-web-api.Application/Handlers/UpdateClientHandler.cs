using contacts_web_api.Application.Commands;
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
    public class UpdateClientHandler : IRequestHandler<UpdateContactCommand, Contact>
    {
        private readonly IContactRepository _contactRepo;

        public UpdateClientHandler(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public async Task<Contact> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var oldContact = await _contactRepo.GetByIdAsync(request.Id);

            if (oldContact == null)
            {
                throw new Exception(message: "Product not found");
            }

            oldContact.Name = request.Name;
            oldContact.BirthDate = request.BirthDate;
            oldContact.MobilePhone = request.MobilePhone;
            oldContact.JobId = request.JobId;

            var newContact = await _contactRepo.UpdateAsync(oldContact);
            return newContact;
        }
    }
}
