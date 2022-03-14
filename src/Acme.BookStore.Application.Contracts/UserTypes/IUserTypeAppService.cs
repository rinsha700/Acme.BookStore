<<<<<<< HEAD
﻿using System;
=======
﻿using Acme.BookStore.Books;
using System;
>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.UserTypes
{
<<<<<<< HEAD
    
=======
>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
    public interface IUserTypeAppService :
        ICrudAppService< //Defines CRUD methods
            UserTypeDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateUserTypeDto> //Used to create/update a book
<<<<<<< HEAD
    {

    }
=======

    {



    }




>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
}
