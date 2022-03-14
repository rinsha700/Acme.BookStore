using Acme.BookStore.Parties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService :

        CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>, //Used to create/update a book
        IBookAppService //implement the IBookAppService
        {
        IRepository<Book, Guid> bookrepository;
        IRepository<Partie, Guid> partierepository;
        public BookAppService(IRepository<Book, Guid> bookrepository, IRepository<Partie, Guid> partierepository)
                : base(bookrepository)
            {

            this.bookrepository = bookrepository;
            this.partierepository = partierepository;
            }

<<<<<<< HEAD
      
    }
=======
        public async Task<CombainedData>  GetCombainedData()
        {
            var bookList = await bookrepository.GetListAsync();
            var partieList = await partierepository.GetListAsync();

            var result = new CombainedData();

            

            result.Book = ObjectMapper.Map<Book, BookDto>(bookList[0]);
            result.Partie = ObjectMapper.Map<Partie, PartieDto>(partieList[0]);


            return result;
        }

    }// class emd


    public class CombainedData
    {

        public BookDto Book { get; set; }   



        public PartieDto Partie { get; set; }
    }

    

>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
}
