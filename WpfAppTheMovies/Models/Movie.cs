using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTheMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public TimeOnly Duration { get; set; }
        public string? Genre { get; set; }

        // movie constructor
        public Movie(int id, string title, TimeOnly duration, string genre)
        {
            Id = id;
            Title = title;
            Duration = duration;
            Genre = genre;
        }

        // movie methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Title: {Title}, Duration: {Duration}, Genre: {Genre}");
        }
        public override string ToString()
        {
            return $"{Id} - {Title} ({Duration}) - {Genre}";
        }


    }
}
