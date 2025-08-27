using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTheMovies.Models.Repository;
using WpfAppTheMovies.Models;

namespace TheMoviesTest
{
    [TestClass]
    public class CinemaRepoTest
    {
        [TestMethod]
        public void AddCinema_ShouldStoreCorrectly()
        {
            // Arrange
            CinemaRepo repo = new CinemaRepo();
            Cinema cinema = new Cinema("testName", "testCity");

            // Act
            repo.AddCinema(cinema);
            var all = repo.GetAll();

            // Assert
            Assert.AreEqual(1, all.Count);
            Assert.AreEqual("testName", all[0].Name);
            Assert.AreEqual("testCity", all[0].City);
        }
    }
}
