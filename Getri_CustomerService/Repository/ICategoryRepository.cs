using Getri_CustomerService.Models;

namespace Getri_CustomerService.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();

        Category SearchCategory(int id);

        Category UpdateCategory(Category category);

        Category CreateCategory(Category category);

        bool DeleteCategory(int id);
    }
}
