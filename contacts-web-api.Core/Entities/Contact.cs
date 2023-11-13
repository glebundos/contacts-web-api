using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Core.Entities
{
    public class Contact
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string MobilePhone { get; set; }

        public Guid JobId { get; set; }

        public DateTime BirthDate { get; set; }

        // foreign
        public virtual Job Job { get; set; }
    }
}
