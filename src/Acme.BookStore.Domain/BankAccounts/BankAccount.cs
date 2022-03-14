using Acme.BookStore.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.BankAccounts
{
    public class BankAccount:FullAuditedAggregateRoot<Guid>
    {
        
        public string? Name { get; set; }
        public string AccountNo { get; set; }
        public string Address { get; set; }

        public Guid? UserId { get; set; }
        public virtual User? Users { get; set; }
    }
}
