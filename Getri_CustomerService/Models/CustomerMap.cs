using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Getri_CustomerService.Models
{
    public class CustomerMap
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityBuilderCustomer)
        {
            entityBuilderCustomer.HasKey(t => t.CustomerId); // Primary key
            entityBuilderCustomer.Property(t => t.CustomerId).IsRequired();
            entityBuilderCustomer.Property(t => t.CustomerName).IsRequired();            
            entityBuilderCustomer.Property(t => t.CustomerAge).IsRequired();
            entityBuilderCustomer.Property(t => t.CustomerName).HasMaxLength(50);
            entityBuilderCustomer.Property(t => t.CustomerPhone).IsRequired();
        }
    }
}
