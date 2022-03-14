using Acme.BookStore.UserTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class UserTypeStoreDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<UserType, Guid> _UserTypeRepository;

        public UserTypeStoreDataSeederContributor(IRepository<UserType, Guid> UserTypeRepository)
        {
            _UserTypeRepository = UserTypeRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _UserTypeRepository.GetCountAsync() <= 0)
            {
                await _UserTypeRepository.InsertAsync(
                    new UserType
                    {
                        Name = "Aravinth",
                        Code = "1934"
                    },
                    autoSave: true
                );

                await _UserTypeRepository.InsertAsync(
                    new UserType
                    {
                        Name = "Ashik",
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

