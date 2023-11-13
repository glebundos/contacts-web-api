using contacts_web_api.Core.Entities;
using contacts_web_api.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Core.Repositories
{
    public interface IContactRepository: IRepository<Contact>
    {
    }
}
