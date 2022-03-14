using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Educamps
{
    public class EducampDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Active { get; set; }
        public bool Code { get; set; }
    }
}
