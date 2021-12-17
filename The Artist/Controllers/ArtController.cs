using Microsoft.AspNetCore.Mvc;
using The_Artist.Models;
using The_Artist.Models.repositories;

namespace The_Artist.Controllers
{
    public class ArtController : Controller
    {
        private readonly IArtRepository<Art> artRepository;

        public ArtController(IArtRepository<Art> artRepository)
        {
            this.artRepository = artRepository;
        }

        public IActionResult Index()
        {
            var arts = artRepository.List();

            return View(arts);
        }
    }
}
