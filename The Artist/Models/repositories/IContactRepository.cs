using System.Collections.Generic;

namespace The_Artist.Models.repositories
{
    public interface IContactRepository<Object>
    {
        IList<Object> List();

    }
}
