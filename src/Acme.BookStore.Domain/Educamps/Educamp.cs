using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Educamps
{
    public class Educamp: FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Active { get; set; }
        public bool Code { get; set; }
    }
}
