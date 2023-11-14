using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Application.Commands
{
    public class DeleteContactCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
