using Data.DataContext;
using Repositories.TokioMarineRepositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.TokioMarineRepositories.Product
{
    public class ProductRepository: TokioMarineGenericRepository<Data.Models.Product>, IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
