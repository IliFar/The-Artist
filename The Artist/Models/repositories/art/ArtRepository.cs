using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace The_Artist.Models.repositories.art
{
    public class ArtRepository : IArtRepository<Art>
    {
        private readonly AppDbContext appDbContext;
        public ArtRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IList<Art> GetArtByCategoryId(int id)
        {
            return appDbContext.Arts.Include(c => c.Category).Where(a => a.CategoryId == id).ToList();
        }

        public IList<Art> List()
        {
            return appDbContext.Arts.Include(c => c.Category).ToList();
        }
    }
}
