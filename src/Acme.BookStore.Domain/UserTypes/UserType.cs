using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.UserTypes
{
<<<<<<< HEAD
    public class UserType : FullAuditedAggregateRoot<Guid>
    {

        public string Code { get; set; }
        public string Name { get; set; }
=======
    public class UserType : AuditedAggregateRoot<Guid>
    {
       
        public string Code { get; set; }
        public string Name { get; set; }

>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
        public bool Active { get; set; }


    }
}
<<<<<<< HEAD


=======
>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
