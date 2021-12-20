using The_Artist.Models.repositories;

namespace The_Artist.Models
{
    public class HomeRepository : IHomeRepository
    {
        Home home;
        public HomeRepository()
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
