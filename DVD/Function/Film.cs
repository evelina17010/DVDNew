using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVD.Connection;
using System.Collections.ObjectModel;

namespace DVD.Function
{
    public class Film
    {
         public static ObservableCollection <Film> films {  get; set; }
        public static ObservableCollection<Film> GetFilms()
        {
            return new ObservableCollection<Film>(Connection.Connection.dvd.Film.ToList());

        }
         public static ObservableCollection<Film> SearchFilm(string name)
        {
            return films=new ObservableCollection<Film>(Connection.Connection.dvd.Film.Where(x=>x.Name.Contains(name)).ToList());

        }
        public static Film GetFilmInfo(int id)
        {
            Film selectedFilm=Connection.Connection.dvd.Film.Where(filmID=>filmID.Id==id).FirstOrDefault();
            Film film=new Film()
            {
                Id = selectedFilm.Id,
                Name= selectedFilm.Name,
                id_vozr_ogranich = selectedFilm.id_vozr_ogranich,
                cost_arend = selectedFilm.cost_arend                    
            };
            return film;
        }

  }
}
