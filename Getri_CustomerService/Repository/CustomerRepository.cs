using Getri_CustomerService.EntityFramework;
using Getri_CustomerService.Models;

namespace Getri_CustomerService.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CustomerRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public Customer CreateCustomer(Customer customer)
        {
            /*var result = applicationDbContext.Add(customer);
            applicationDbContext.SaveChanges();
            return result.Entity;*/

            applicationDbContext.Add(customer);
            applicationDbContext.SaveChanges();
            return customer;            
        }

        public bool DeleteCustomer(int id)
        {
            var filteredData = applicationDbContext.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            var result = applicationDbContext.Customers.Remove(filteredData);
            applicationDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return applicationDbContext.Customers.ToList();
        }

        public Customer SearchCustomer(int id)
        {
            //return applicationDbContext.Customers.Find(id);

            return applicationDbContext.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            /*var result = applicationDbContext.Update(customer);
            applicationDbContext.SaveChanges();
            return result.Entity;*/

            applicationDbContext.Update(customer);
            applicationDbContext.SaveChanges();
            return customer;
        }
    }
}
