using Acme.BookStore.Educamps;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Educamps
{
   
      public interface IEducampService :
       ICrudAppService< //Defines CRUD methods
           EducampDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateEducampDto> //Used to create/update a book
    {

    }
    
    
}
