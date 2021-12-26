using System.Collections.Generic;
using System.Linq;

namespace The_Artist.Models.repositories
{
    public class MockArtRepository : IArtRepository<Art>
    {
        IList<Art> artList;

        public MockArtRepository()
        {
            artList = new List<Art>()
            {
                new Art { Id = 1, Title = "Hammer Of Thor", CategoryId = 2, Description = "Hammer Of Thor Is....", Image = "/images/hammer.jpg", Price = 18.25M},
                new Art { Id = 2, Title = "Lamp Of Loki", CategoryId = 4, Description = "Lamp Of Loki is....", Image = "/images/lamp.jpg", Price = 49.25M},
                new Art { Id = 3, Title = "Chair Of Kings", CategoryId = 1, Description = "Chair Of Kings is....", Image = "/images/chair.jpg", Price = 100.25M},
                new Art { Id = 4, Title = "Knife Of Valhala", CategoryId = 3, Description = "Knife Of Valhala is....", Image = "/images/knife.jpg", Price = 298.25M},
                new Art { Id = 5, Title = "Boat Of Poseidon", CategoryId = 5, Description = "Boat Of Poseidon is....", Image = "/images/boat.jpg", Price = 55.25M}
            };
        }

        public IList<Art> GetArtByCategoryId(int id)
        {
            return artList.Where(a => a.CategoryId == id).ToList();
        }

        public IList<Art> List()
        {
            return artList;
        }
    }
}
