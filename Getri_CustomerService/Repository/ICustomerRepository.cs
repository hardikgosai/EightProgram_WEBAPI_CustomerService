using Getri_CustomerService.Models;

namespace Getri_CustomerService.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();

        Customer SearchCustomer(int id);

        Customer UpdateCustomer(Customer customer);

        Customer CreateCustomer(Customer customer);

        bool DeleteCustomer(int id);
    }
}
