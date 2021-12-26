using System.Collections.Generic;
using The_Artist.Models;

namespace The_Artist.ViewModels
{
    public class ArtListViewModel
    {
        public IEnumerable<Art> Arts { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
