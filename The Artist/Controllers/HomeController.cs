using Microsoft.AspNetCore.Mvc;
using The_Artist.Models.repositories;

namespace The_Artist.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepository homeRepository;

        public HomeController(IHomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }

        public IActionResult Index()
        {
            return View(homeRepository.ShowImage());
        }
    }
}
