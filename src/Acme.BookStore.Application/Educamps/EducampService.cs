using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Educamps
{
    public  class EducampService :
       CrudAppService<
           Educamp, //The Book entity
           EducampDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateEducampDto>, //Used to create/update a book
         IEducampService //implement the IBookAppService
    {
        public EducampService(IRepository<Educamp, Guid> repository)
               : base(repository)


        {

        }


    }
    
    
}
