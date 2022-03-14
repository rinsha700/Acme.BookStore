using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Parties
{
    public interface IPartieAppService:
        ICrudAppService< //Defines CRUD methods
            PartieDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePartieDto> //Used to create/update a book

        {

        }

    
}
