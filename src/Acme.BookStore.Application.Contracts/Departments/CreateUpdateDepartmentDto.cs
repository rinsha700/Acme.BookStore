using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Departments
{
        public class CreateUpdateDepartmentDto
        {

            [Required]
            [StringLength(128)]
            public string Name { get; set; }

            [Required]
            [StringLength(40)]
            public string Code { get; set; }



            [Required]
            public bool Active { get; set; }
        }
}
