using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTheMovies.Models.Interfaces;

namespace WpfAppTheMovies.Models.Repository
{
    public class CinemaRepo : ICinemaRepo
    {
        private List<Cinema> cinemas = new List<Cinema>();

        public void AddCinema(Cinema cinema)
        {
            cinemas.Add(cinema);
        }

        public List<Cinema> GetAll()
        {
            return cinemas;
        }
    }
}
