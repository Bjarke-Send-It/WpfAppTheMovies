using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfAppTheMovies.Models.Repository;
using WpfAppTheMovies.Models;

namespace WpfAppTheMovies.Tests
{
    [TestClass]
    public class FilmRepoTests
    {
        [TestMethod]
        public void AddFilm_ShouldStoreCorrectly()
        {
            // Arrange
            var repo = new FilmRepo();
            var film = new Film("Repo Test", 90, "Action");

            // Act
            repo.AddFilm(film);
            var all = repo.GetAll();

            // Assert
            Assert.AreEqual(1, all.Count);
            Assert.AreEqual("Repo Test", all[0].Title);
        }
    }
}
