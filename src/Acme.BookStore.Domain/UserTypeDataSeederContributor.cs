using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.UserTypes;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class UserTypeDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<UserType, Guid> _UserTypeRepository;

        public UserTypeDataSeederContributor(IRepository<UserType, Guid> UserTypeRepository)
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
                        Name = "Aravi",
                        Code = "UT1",
                        
                    },
                    autoSave: true
                );

                await _UserTypeRepository.InsertAsync(
                    new UserType
                    {
                        Name = "Rinsha",
                        Code = "UT2",
                    },
                    autoSave: true
                );
            }
        }
    }
}