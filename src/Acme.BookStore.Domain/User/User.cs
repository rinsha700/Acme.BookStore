using Acme.BookStore.BankAccounts;
using Acme.BookStore.UserAdressess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Users
{
    public class User:FullAuditedAggregateRoot<Guid>
    {
        public Guid UId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

      public virtual UserAddress? UserAddressess { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>() { };

       

    }
}
