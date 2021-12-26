using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Artist.Controllers;
using The_Artist.Models;
using The_Artist.Models.repositories;
using Xunit;

namespace TheArtist.Tests
{
    public class TestControllers
    {
        private readonly Mock<IArtRepository<Art>> artRepo;
        private readonly ArtController controller;

        public TestControllers()
        {
            artRepo = new Mock<IArtRepository<Art>>();
            controller = new ArtController(artRepo.Object);
        }

        [Fact]
        public void Index_Test_Should_Return_ViewForIndex()
        {
            var result = controller.Index();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Category_Test_Should_Return_ViewForCategory()
        {
            var id = 1;

            var result = controller.Category(id);

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }


    }
}
