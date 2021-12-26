using Microsoft.AspNetCore.Mvc;
using The_Artist.Models;
using The_Artist.Models.repositories;
using The_Artist.ViewModels;

namespace The_Artist.Controllers
{
    public class ArtController : Controller
    {
        private readonly IArtRepository<Art> artRepository;
        private readonly ArtListViewModel artListViewModel;

        public ArtController(IArtRepository<Art> artRepository)
        {
            this.artRepository = artRepository;
            artListViewModel = new ArtListViewModel();
        }

        public IActionResult Index()
        {
            artListViewModel.Arts = artRepository.List();

            return View(artListViewModel);
        }
        public IActionResult Category(int id)
        {
            artListViewModel.Arts = artRepository.GetArtByCategoryId(id);

            return View(artListViewModel);
        }
    }
}
