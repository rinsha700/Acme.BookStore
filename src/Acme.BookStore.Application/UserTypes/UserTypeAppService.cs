using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.UserTypes
{
    public class UserTypeAppService :
        CrudAppService<
            UserType, //The Book entity
            UserTypeDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateUserTypeDto>, //Used to create/update a book
        IUserTypeAppService //implement the IBookAppService
    {
        IRepository<Book, Guid> bookrepository;
        IRepository<UserType, Guid> usertyperepository;
        public UserTypeAppService(IRepository<UserType, Guid> repository,
            IRepository<UserType, Guid> usertyperepository)
              : base(repository)
        {
            this.bookrepository = bookrepository;
            this.usertyperepository = usertyperepository;
        }

        [HttpGet]
        public async Task<CombainedData> helloAsync()


        {
            var bookList = await bookrepository.GetListAsync();
            var UserTypeList = await usertyperepository.GetListAsync();

            var result = new CombainedData();



            result.Book = ObjectMapper.Map<Book, BookDto>(bookList[0]);
            result.UserType = ObjectMapper.Map<UserType, UserTypeDto>(UserTypeList[0]);
            //result.usertype = ObjectMapper.Map<user, PartyDto>(partieList[0]);


            return result;


        }



    }
}
