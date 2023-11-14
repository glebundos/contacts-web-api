using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Application.Commands
{
    public class CreateContactCommand : IRequest<Guid>
    {
        public string Name { get; set; }

        public string MobilePhone { get; set; }

        public Guid JobId { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
