using System.Collections.Generic;
using System.Linq;

namespace The_Artist.Models.repositories
{
    public class ArtRepository : IArtRepository<Art>
    {
        List<Art> artList;

        public ArtRepository()
        {
            artList = new List<Art>()
            {
                new Art { Id = 1, Title = "Hammer Of Thor", Description = "Hammer Of Thor Is....", Image = "/images/1.jpg", Price = 18.25M},
                new Art { Id = 2, Title = "Lamp Of Loki", Description = "Lamp Of Loki is....", Image = "/images/2.jpg", Price = 49.25M},
                new Art { Id = 3, Title = "Chair Of Kings", Description = "Chair Of Kings is....", Image = "/images/4.jpg", Price = 100.25M},
                new Art { Id = 4, Title = "Knife Of Valhala", Description = "Knife Of Valhala is....", Image = "/images/3.jpg", Price = 298.25M}
            };
        }

        public void Add(Art art)
        {
            artList.Add(art);
        }

        public Art Get(int id)
        {
            var art = artList.FirstOrDefault(a => a.Id == id);

            return art;
        }

        public IList<Art> List()
        {
            return artList;
        }
    }
}
