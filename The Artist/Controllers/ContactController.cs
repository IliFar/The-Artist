using Microsoft.AspNetCore.Mvc;
using The_Artist.Models;
using The_Artist.Models.repositories;

namespace The_Artist.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository<Contact> contactRepository;

        public ContactController(IContactRepository<Contact> contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            var contactInfo = contactRepository.List();

            return View(contactInfo);
        }
    }
}
