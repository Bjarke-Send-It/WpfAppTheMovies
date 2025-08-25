using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTheMovies.Models.Interfaces;

namespace WpfAppTheMovies.Models.Repository
{
    public class FilmRepo : IFilmRepo
    {
        private List<Film> films = new List<Film>();
        public void AddFilm(Film film)
        {
            films.Add(film);
        }

        public List<Film> GetAll()
        {
            return films;
        }
    }
}
