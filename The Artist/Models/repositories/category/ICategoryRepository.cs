using System.Collections.Generic;
namespace The_Artist.Models.repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
