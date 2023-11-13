using contacts_web_api.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Application.Queries
{
    public class GetAllContactsQuery : IRequest<List<Contact>>
    {
    }
}
