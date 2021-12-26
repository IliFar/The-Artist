using The_Artist.Models.repositories;

namespace The_Artist.Models
{
    public class MockHomeRepository : IHomeRepository
    {
        Home home;
        public MockHomeRepository()
        {
            home = new Home()
            {
                Image = "/images/homepicture.jpg"
            };
        }

        public Home ShowImage()
        {
            return home;
        }
    }
}
