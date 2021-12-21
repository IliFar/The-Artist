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

        public Art GetArtById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Art> List()
        {
            return appDbContext.Arts.Include(a => a.Category).ToList();
        }


    }
}
