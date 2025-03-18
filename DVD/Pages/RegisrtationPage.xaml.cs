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
using DVD.Function;

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegisrtationPage.xaml
    /// </summary>
    public partial class RegisrtationPage : Page
    {
        public RegisrtationPage()
        {
            InitializeComponent();
        }

        private void RegesrtRegbtn_Click(object sender, RoutedEventArgs e)
        {
           string fio= Fiotxb.Text.Trim();
            string phone= Tntxb.Text.Trim();
            string pass= Reglogintxb.Text.Trim();
            if(Fiotxb!=null && Reglogintxb!=null)
            {
Registration.RegistrationSotr(fio, phone, pass);
                System.Windows.MessageBox.Show("Регистрация прошла успешна");
                NavigationService.Navigate(new AutorizationPage());
            }
        }

        private void btnVhod_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AutorizationPage());
        }
    }
}
