using System.Collections.Generic;

namespace The_Artist.Models.repositories
{
    public interface IArtRepository<Object>
    {
        IList<Object> List();
        Object Get(int id);
        void Add(Object obj);
    }
}
