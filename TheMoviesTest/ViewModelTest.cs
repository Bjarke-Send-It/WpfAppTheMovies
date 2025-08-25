using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfAppTheMovies;
using WpfAppTheMovies.ViewModels;

namespace WpfAppTheMovies.Tests
{
    [TestClass]
    public class FilmViewModelTests
    {
        [TestMethod]
        public void AddFilmCommand_ShouldAddFilmToList()
        {
            // Arrange
            var vm = new FilmViewModel
            {
                Title = "Test Film",
                Duration = 123,
                Genre = "Thriller"
            };

            // Act
            vm.AddFilmCommand.Execute(null);

            // Assert
            Assert.AreEqual(1, vm.Films.Count);
            Assert.AreEqual("Test Film", vm.Films[0].Title);
            Assert.AreEqual(123, vm.Films[0].Duration);
            Assert.AreEqual("Thriller", vm.Films[0].Genre);
        }
    }
}
