using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyManger.Core.Models;

namespace PropertyManager.Core.Domain
{
    public class Tenant
    {
        public int TenantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Lease> Leases { get; set; }

        public void Update(TenantModel tenant)
        {
            FirstName = tenant.FirstName;
            LastName = tenant.LastName;
            TelephoneNumber = tenant.TelephoneNumber;
            Email = tenant.Email;
        }
    }
}
