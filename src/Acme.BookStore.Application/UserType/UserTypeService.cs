using Acme.BookStore.UserTypes;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
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
        public UserTypeAppService(IRepository<UserType, Guid> repository)
            : base(repository)
        {

        }

        //Task<BookDto> ICreateAppService<BookDto, CreateUpdateBookDto>.CreateAsync(CreateUpdateBookDto input)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<BookDto> IReadOnlyAppService<BookDto, BookDto, Guid, PagedAndSortedResultRequestDto>.GetAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<PagedResultDto<BookDto>> IReadOnlyAppService<BookDto, BookDto, Guid, PagedAndSortedResultRequestDto>.GetListAsync(PagedAndSortedResultRequestDto input)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<BookDto> IUpdateAppService<BookDto, Guid, CreateUpdateBookDto>.UpdateAsync(Guid id, CreateUpdateBookDto input)
        //{
        //    throw new NotImplementedException();
        //}
    }
}





