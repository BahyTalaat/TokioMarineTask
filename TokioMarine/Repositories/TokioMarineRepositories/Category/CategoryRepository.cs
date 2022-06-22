using Data.DataContext;
using Repositories.TokioMarineRepositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.TokioMarineRepositories.Category
{
    public class CategoryRepository: TokioMarineGenericRepository<Data.Models.Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
