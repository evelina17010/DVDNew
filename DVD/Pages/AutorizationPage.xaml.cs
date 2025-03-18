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
using DVD.Connection;

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public static Sotrudnik sotrudnik;
        public AutorizationPage()
        {
            InitializeComponent();
        }
       
        private void Vhodbtn_Click(object sender, RoutedEventArgs e)
        {
           int login=Convert.ToInt32(Logintxb.Text.Trim());
            string password= Parolpsw.Password.Trim();
            sotrudnik = Authorisation.AuthorisationSotr(login, password);
            if (sotrudnik != null)
            {
                NavigationService.Navigate(new CapchaPage());

            }
            else MessageBox.Show("Логин или пароль неверный","error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Regesrtbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Reg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new RegisrtationPage());
        }

        private void Reg_MouseEnter(object sender, MouseEventArgs e)
        {
            Reg.Foreground=new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Reg_MouseLeave(object sender, MouseEventArgs e)
        {
            Reg.Foreground = new SolidColorBrush(Colors.Black);
        }
    }

}
