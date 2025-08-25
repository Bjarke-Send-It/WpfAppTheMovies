using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTheMovies.Models.Interfaces
{
    internal interface ICinemaRepo
    {
        void AddCinema(Cinema cinema);
        List<Cinema> GetAll();
    }
}
