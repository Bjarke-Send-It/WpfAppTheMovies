using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTheMovies.Models
{
    public class Film
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Genre { get; set; }
        // duration som timespan i stedet for int?
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime Schedule { get; set; }
        public string cinemaHall { get; set; }


     
        public Film(string title, int duration, string genre)
        {
            Title = title;
            Duration = duration;
            Genre = genre;
        }
        // ny constructor med flere parametre

    }
}
