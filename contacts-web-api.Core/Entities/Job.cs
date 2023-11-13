using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Core.Entities
{
    public class Job
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        // foreign
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
