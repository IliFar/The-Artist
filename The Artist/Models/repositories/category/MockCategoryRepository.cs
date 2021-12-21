using System.Collections.Generic;

namespace The_Artist.Models.repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories =>
            new List<Category>
            {
                new Category { CategoryId = 1,CategoryName = "Chairs", Description ="All The Power Chairs"},
                new Category { CategoryId = 2,CategoryName = "Hammers", Description ="All The Power Chairs"},
                new Category { CategoryId = 3,CategoryName = "Knives", Description ="All The Power Chairs"},
                new Category { CategoryId = 4,CategoryName = "Lamps", Description ="All The Power Chairs"},
                new Category { CategoryId = 5,CategoryName = "Boats", Description ="All The Power Chairs"},
            };
        
    }
}
