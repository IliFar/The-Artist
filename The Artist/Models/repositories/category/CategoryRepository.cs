using System.Collections.Generic;
using System.Linq;

namespace The_Artist.Models.repositories.category
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategories => appDbContext.Categories;

        public Category GetCategory(int id)
        {
            return appDbContext.Categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
