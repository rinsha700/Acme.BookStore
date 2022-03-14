using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.UserTypes
{
<<<<<<< HEAD
    public class UserTypeDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }

    }
}
=======
    public class UserTypeDto:AuditedEntityDto<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}

>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
