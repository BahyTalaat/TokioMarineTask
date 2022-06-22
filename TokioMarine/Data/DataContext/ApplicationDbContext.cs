using Data.ConnectionsStrings;
using Data.DbModels.SecuritySchema;
using Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataContext
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(ConnectionString.LocalDbConnectionString);
            base.OnConfiguring(optionsBuilder); 
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);  
        }
        public virtual DbSet<Category> Categories { get; set; } 
        public virtual DbSet<Product> Products { get; set; } 
        public virtual DbSet<BillProduct> BillProducts { get; set; } 
    }
}
