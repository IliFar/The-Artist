using System.Collections.Generic;

namespace The_Artist.Models.repositories
{
    public interface IArtRepository<Object>
    {
        IList<Object> List();
        IList<Object> GetArtByCategoryId(int id);
    }
}
