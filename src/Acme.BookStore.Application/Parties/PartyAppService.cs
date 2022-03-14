using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Parties
{
    public class PartyAppService :
       CrudAppService<
           Party, //The Book entity
           PartyDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdatePartyDto>, //Used to create/update a book
         IPartyAppService //implement the IBookAppService
    {
        //IRepository<Party, Guid> partyrepository;
        //IRepository<Book, Guid> bookrepository;


        public PartyAppService(IRepository<Party, Guid> repository):base(repository)
        {

        }
        //     IRepository<Book, Guid> bookrepository)
        //      : base(partyrepository)
        //{
        //    this.partyrepository = partyrepository; 
        //    this.bookrepository=bookrepository;

        //}

        //public async Task<ContainerData> GetDetailsAsync()
        //{
        // var bookList= await bookrepository.GetListAsync();
        //    var partyList = await partyrepository.GetListAsync();
        //    var result = new ContainerData();

        //    result.Book= ObjectMapper.Map<Book, BookDto>(bookList[0]);
        //    result.Party = ObjectMapper.Map<Party, PartyDto>(partyList[0]);

        //    return result;
        //}


    }
}

