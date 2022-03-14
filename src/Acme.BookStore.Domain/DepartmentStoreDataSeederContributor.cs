using Acme.BookStore.Departments;
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
    public class DepartmentStoreDataSeederContributor
         : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Department, Guid> _DepartmentRepository;

        public DepartmentStoreDataSeederContributor(IRepository<Department, Guid> DepartmentRepository)
        {
            _DepartmentRepository = DepartmentRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _DepartmentRepository.GetCountAsync() <= 0)
            {
                await _DepartmentRepository.InsertAsync(
                    new Department
                    {
                        Name = "Nibin",
                        Code = "1934"
                    },
                    autoSave: true
                );

                await _DepartmentRepository.InsertAsync(
                    new Department
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
    
    

