using System.Collections.Generic;
using System.Linq;

namespace The_Artist.Models.repositories
{
    public class MockArtRepository : IArtRepository<Art>
    {
        List<Art> artList;

        public MockArtRepository()
        {
            artList = new List<Art>()
            {
                new Art { Id = 1, Title = "Hammer Of Thor", Description = "Hammer Of Thor Is....", Image = "/images/hammer.jpg", Price = 18.25M},
                new Art { Id = 2, Title = "Lamp Of Loki", Description = "Lamp Of Loki is....", Image = "/images/lamp.jpg", Price = 49.25M},
                new Art { Id = 3, Title = "Chair Of Kings", Description = "Chair Of Kings is....", Image = "/images/chair.jpg", Price = 100.25M},
                new Art { Id = 4, Title = "Knife Of Valhala", Description = "Knife Of Valhala is....", Image = "/images/knife.jpg", Price = 298.25M},
                new Art { Id = 5, Title = "Boat Of Poseidon", Description = "Boat Of Poseidon is....", Image = "/images/boat.jpg", Price = 55.25M}
            };
        }

        public Art GetArtById(int id)
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
