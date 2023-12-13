using Getri_CustomerService.Models;
using Microsoft.EntityFrameworkCore;

namespace Getri_CustomerService.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Category> Categories { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            new CustomerMap(modelBuilder.Entity<Customer>());
        }
    }
}
