using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// references
using System.Linq;
using FinalB.Controllers;
using FinalB.Models;
using System.Web.Mvc;
using Moq;

namespace FinalB.Tests.Controllers
{
    [TestClass]
    public class MoviesControllerTest
    {
        MoviesController controller;
        List<Movie> movies;
        Mock<IMovieRepository> mock;

        [TestInitialize]
        public void TestInitialize()
        {
            // arrange
            mock = new Mock<IMovieRepository>();

            movies = new List<Movie>
            {
                new Movie { MovieID = 1, Title = "Movie 1", Year = 2000, Revenue = 300000 },
                new Movie { MovieID = 2, Title = "Movie 2", Year = 2005, Revenue = 250000 },
                new Movie { MovieID = 3, Title = "Movie 2", Year = 2010, Revenue = 200000 }
            };

            mock.Setup(m => m.Movies).Returns(movies.AsQueryable());

            controller = new MoviesController(mock.Object);
        }

        [TestMethod]
        public void IndexValidLoadsMovies()
        {

            // Act
        

            // Assert

        }

        [TestMethod]
        public void DetailsValidId()
        {
            // act
            string result = controller.Details();
            // assert
        }

        [TestMethod]
        public void DetailsInvalidId()
        {
            // act
            string result = movies.FindIndex(5);
            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DetailsMissingId()
        {
            // act
            string result = null;
            // assert
            Assert.IsNotNull(result);
        }
    }
}
