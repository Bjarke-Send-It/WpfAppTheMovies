using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppTheMovies.Models.Interfaces;
using WpfAppTheMovies.Models.Repository;
using WpfAppTheMovies.Models;
using WpfAppTheMovies.Interfaces;

namespace WpfAppTheMovies.ViewModels
{
    public class FilmViewModel : INotifyPropertyChanged
    {
        private readonly IFilmRepo _filmRepo;

        public ObservableCollection<Film> Films { get; set; } = new ObservableCollection<Film>();

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        private int _duration;
        public int Duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged();
            }
        }

        private string _genre;
        public string Genre
        {
            get => _genre;
            set { _genre = value; OnPropertyChanged(); }
        }
        public ICommand AddFilmCommand { get; set; }

        public FilmViewModel()
        {
            _filmRepo = new FilmRepo();

            foreach (var film in _filmRepo.GetAll())
                Films.Add(film);

            AddFilmCommand = new RelayCommand(AddFilm);
        }

        private void AddFilm()
        {
            var newFilm = new Film(Title, Duration, Genre);

            _filmRepo.AddFilm(newFilm);

            Films.Add(newFilm);

            Title = string.Empty;
            Duration = 0;
            Genre = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
