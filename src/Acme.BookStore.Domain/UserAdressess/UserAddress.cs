using Acme.BookStore.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.UserAdressess
{
    public class UserAddress: FullAuditedAggregateRoot<Guid>
    {
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Country { get; set; }

        public Guid UserId { get; set; }
        public virtual User? Users { get; set; }

       // public virtual ICollection<UserAddress> UserAddressess { get; set; }
    }
}
