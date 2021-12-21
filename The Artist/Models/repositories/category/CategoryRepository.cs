using System.Collections.Generic;

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
    }
}
