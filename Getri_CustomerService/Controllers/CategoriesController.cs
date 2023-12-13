using Getri_CustomerService.Models;
using Getri_CustomerService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Getri_CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository iCategoryRepository;

        public CategoriesController(ICategoryRepository _iCategoryRepository)
        {
            iCategoryRepository = _iCategoryRepository;
        }

        [HttpGet("SearchCategory")]
        //[FromBody] attribute is used to specify that the value should be read from the request body.
        public IActionResult FetchCategory(int id)
        {
            var result = iCategoryRepository.SearchCategory(id);

            return Ok(result);
        }

        [HttpGet("GetCategories")]
        public IActionResult FetchCategories()
        {
            var result = iCategoryRepository.GetCategories();

            return Ok(result);
        }

        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(Category category)
        {
            var result = iCategoryRepository.CreateCategory(category);

            return Ok(result);
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory(Category category)
        {
            var result = iCategoryRepository.UpdateCategory(category);

            return Ok(result);
        }

        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteCategory(int id)
        {
            var result = iCategoryRepository.DeleteCategory(id);

            return Ok(result);
        }            
    }
}
