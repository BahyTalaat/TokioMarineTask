using Autofac;
using Repositories.TokioMarineRepositories.Bill;
using Repositories.TokioMarineRepositories.Category;
using Repositories.TokioMarineRepositories.Product;
using Repositories.UOW;
using Services.Email;
using Services.TokioMarine.Category;
using Services.TokioMarine.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AutoFacConfiguration :Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            #region UOW
            //Register Unit of work service
            builder.RegisterGeneric(typeof(UnitOfWork<>)).As(typeof(IUnitOfWork<>)); 
            #endregion

            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<BillRepository>().As<IBillRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<EmailSender>().As<IEmailSender>();
            
        }
    }
}
