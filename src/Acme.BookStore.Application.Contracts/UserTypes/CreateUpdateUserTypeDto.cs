using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel;
>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.UserTypes
{
    public class CreateUpdateUserTypeDto
    {
<<<<<<< HEAD
       
            [Required]
            [StringLength(128)]
            public string Name { get; set; }

            [Required]
            [StringLength(40)]
        public string Code { get; set; } 

            

            [Required]
            public bool Active { get; set; }
        }
=======

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string code { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

    }
>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
}
