using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using The_Artist.Controllers;
using The_Artist.Models.repositories;
using Xunit;

namespace TheArtist.Tests
{
    public class TestModels
    {
        private readonly MockArtRepository art;
        private readonly MockCategoryRepository category;

        public TestModels()
        {
            art = new MockArtRepository();
            category = new MockCategoryRepository();
        }

        [Fact]
        public void Test_Should_Retrun_ArtByCategoryId()
        {
            var categoryId = 1;

            var data = art.GetArtByCategoryId(categoryId);

            Assert.NotNull(data);
        }
        [Fact]
        public void Test_Should_Return_AllArt()
        {
            var data = art.List();

            Assert.NotEmpty(data);
        }
    }
}

