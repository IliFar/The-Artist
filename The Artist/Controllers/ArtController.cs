using Microsoft.AspNetCore.Mvc;
using The_Artist.Models;
using The_Artist.Models.repositories;
using The_Artist.ViewModels;

namespace The_Artist.Controllers
{
    public class ArtController : Controller
    {
        private readonly IArtRepository<Art> artRepository;
        private readonly ICategoryRepository categoryRepository;

        public ArtController(IArtRepository<Art> artRepository, ICategoryRepository categoryRepository)
        {
            this.artRepository = artRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            ArtListViewModel artListViewModel = new ArtListViewModel();
            artListViewModel.Arts = artRepository.List();

            artListViewModel.CurrentCategory = "CheeseCake";

            return View(artListViewModel);
        }
    }
}
