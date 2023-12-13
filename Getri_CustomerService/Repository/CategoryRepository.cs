using Getri_CustomerService.EntityFramework;
using Getri_CustomerService.Models;

namespace Getri_CustomerService.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CategoryRepository(ApplicationDbContext _context)
        {
            applicationDbContext = _context;
        }

        public Category CreateCategory(Category category)
        {
            applicationDbContext.Add(category);
            applicationDbContext.SaveChanges();
            return category;
        }

        public bool DeleteCategory(int id)
        {
            applicationDbContext.Remove(applicationDbContext.Categories.Find(id));
            applicationDbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Category> GetCategories()
        {
            //applicationDbContext.Categories.ToList();
            return applicationDbContext.Categories.ToList();
        }

        public Category SearchCategory(int id)
        {
            applicationDbContext.Categories.Find(id);
            return applicationDbContext.Categories.Find(id);
        }

        public Category UpdateCategory(Category category)
        {
            applicationDbContext.Update(category);
            applicationDbContext.SaveChanges();
            return category;
        }
    }
}
