using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using DVD.Function;

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для FilmListPage.xaml
    /// </summary>
    public partial class FilmListPage : Page
    {
        public static ObservableCollection<Film> filmlist {  get; set; }
        public FilmListPage()
        {
            InitializeComponent();
            filmlist=Film.GetFilms();
            this.DataContext = this;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void SearchTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            filmlist = Film.GetFilms();
            if (SearchTextBox.Text != null)
            {
                filmlist=Film.SearchFilm(SearchTextBox.Text.Trim());
            }
            if (filmlist.Count == 0)
            {
                MessageBox.Show("ничего не найдено");
            }
            else { }
            MoviesListView.ItemsSource= filmlist;
        }

    }
}
