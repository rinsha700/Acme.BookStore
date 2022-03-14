using Acme.BookStore.Parties;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Parties
{
    public class PartieAppService :
        CrudAppService<
            Partie, //The Book entity
            PartieDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePartieDto>, //Used to create/update a book
        IPartieAppService //implement the IBookAppService
    {
        IRepository<Partie, Guid> repository;
        public PartieAppService(IRepository<Partie, Guid> repository)
            : base(repository)
        {
            this.repository = repository;
        }

        public override Task<PagedResultDto<PartieDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return base.GetListAsync(input);
        }
        public async Task<List<Partie>> GetAll2Async()
        {
           var result =await repository.GetListAsync();
            var   firstParty = result[0];



            var partyDto1=ObjectMapper.Map<Partie,PartieDto>(firstParty);

            var partyDto = new PartieDto();
            partyDto.Code=firstParty.Code;  
            partyDto.Name=firstParty.Name;  
           /// continuee


            return result;
        }



    }
}