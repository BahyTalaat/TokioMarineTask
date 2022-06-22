using Data.DataContext;
using Repositories.TokioMarineRepositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.TokioMarineRepositories.Bill
{
    public class BillRepository: TokioMarineGenericRepository<Data.Models.Bill>, IBillRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public BillRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
