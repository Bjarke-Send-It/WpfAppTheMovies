using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTheMovies.Models.Interfaces
{
    public interface IFilmRepo
    {
        void AddFilm(Film film);
        List<Film> GetAll();
    }
}
