using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.Parties;
using Acme.BookStore.UserTypes;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class PartieDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Partie, Guid> _PartieRepository;

        public PartieDataSeederContributor(IRepository<Partie, Guid> PartieRepository)
        {
            _PartieRepository = PartieRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _PartieRepository.GetCountAsync() <= 0)
            {
                await _PartieRepository.InsertAsync(
                    new Partie
                    {
                        Name = "Party1",
                        Code = "P1",

                    },
                    autoSave: true
                );

                await _PartieRepository.InsertAsync(
                    new Partie
                    {
                        Name = "Party2",
                        Code = "P22",
                    },
                    autoSave: true
                );
            }
        }
    }
}