using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Parties
{
   
        public class PartyDto : AuditedEntityDto<Guid>
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public bool Active { get; set; }

        }
    }

