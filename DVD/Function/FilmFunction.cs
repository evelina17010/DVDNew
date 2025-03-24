using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVD.Connection;


namespace DVD.Function
{
    internal class FilmFunction
    {
        public static ObservableCollection<Film> films { get; set; }
        public static ObservableCollection<Film> GetFilms()
        {
            return new ObservableCollection<Film>(DBconn.dvd.Film.ToList());
        }

        public static ObservableCollection<Film> SearchFilm(string name)
        {
            return films = new ObservableCollection<Film>(DBconn.dvd.Film.Where(x => x.Name.Contains(name)).ToList());

        }
        public static Film GetFilmInfo(int id)
        {
            Film selectedFilm = DBconn.dvd.Film.Where(filmId => filmId.Id == id).FirstOrDefault();
            Film film = new Film()
            {
                Id = selectedFilm.Id,
                Name = selectedFilm.Name,
                id_vozr_ogranich = selectedFilm.id_vozr_ogranich,
                cost_arend = selectedFilm.cost_arend
            };
            return film;
        }
    }
}
