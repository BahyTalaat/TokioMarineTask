using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Data.ConnectionsStrings;
using Data.DataContext;
using DTO.Email;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokioMarine
{
    public class Startup
    {
        private string defaultLocalDbConnection { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            defaultLocalDbConnection = ConnectionString.LocalDbConnectionString;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationDbContext>(options =>
                               options.UseSqlServer(defaultLocalDbConnection));

            //services.AddControllersWithViews()
            //   .AddNewtonsoftJson(options =>
            //         options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //           );

            // Mail Configure

            var emailConfig = Configuration
                             .GetSection("EmailConfiguration")
                             .Get<EmailConfiguration>();
              services.AddSingleton(emailConfig);

            #region Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            #endregion


            #region Registe our services with Autofac container
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule(new AutoFacConfiguration());
            builder.Populate(services);
            IContainer container = builder.Build();

            #endregion

            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            
        }
    }
}
