using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BookStore
{
    using global::Acme.BookStore.Parties;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Volo.Abp.Data;
    using Volo.Abp.DependencyInjection;
    using Volo.Abp.Domain.Repositories;

    namespace Acme.BookStore.Parties
    {
        public class PartyStoreDataSeederContributor
        : IDataSeedContributor, ITransientDependency
        {
            private readonly IRepository<Party, Guid> _PartyRepository;

            public PartyStoreDataSeederContributor(IRepository<Party, Guid> PartyRepository)
            {
                _PartyRepository = PartyRepository;
            }

            public async Task SeedAsync(DataSeedContext context)
            {
                if (await _PartyRepository.GetCountAsync() <= 0)
                {
                    await _PartyRepository.InsertAsync(
                        new Party
                        {
                            Name = "Nibin",
                            Code = "1934"
                        },
                        autoSave: true
                    );

                    await _PartyRepository.InsertAsync(
                        new Party
                        {
                            Name = "Rinshad",
                            Code = "1234"

                        },
                        autoSave: true
                    );
                }
                {
                }

            }
        }
    }
}

