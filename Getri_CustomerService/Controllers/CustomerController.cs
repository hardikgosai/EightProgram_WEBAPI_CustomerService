using Getri_CustomerService.Models;
using Getri_CustomerService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Getri_CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository iCustomerRepository;

        public CustomerController(ICustomerRepository _iCustomerRepository)
        {
            iCustomerRepository = _iCustomerRepository;
        }

        [HttpGet("SearchCustomer")]
        //[FromBody] attribute is used to specify that the value should be read from the request body.
        public IActionResult FetchCustomer(int id)
        {
            var result = iCustomerRepository.SearchCustomer(id);

            return Ok(result);
        }

        [HttpGet("GetCustomers")]
        public IActionResult FetchCustomers()
        {
            var result = iCustomerRepository.GetCustomers();

            return Ok(result);
        }

        [HttpPost("CreateCustomer")]
        public IActionResult CreateCustomer(Customer customer)
        {
            var result = iCustomerRepository.CreateCustomer(customer);

            return Ok(result);
        }

        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            var result = iCustomerRepository.UpdateCustomer(customer);

            return Ok(result);
        }

        [HttpDelete("DeleteCustomer")]
        public IActionResult DeleteCustomer(int id)
        {
            var result = iCustomerRepository.DeleteCustomer(id);

            return Ok(result);
        }
    }
}
