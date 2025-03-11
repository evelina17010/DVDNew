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

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для CapchaPage.xaml
    /// </summary>
    public partial class CapchaPage : Page
    { Random rnd=new Random();
        public string capcha = "";
        public CapchaPage()
        {
            InitializeComponent();
            UpdateCaptcha();
            
        }
        private void GenerateNoise(int volumeNoise)
        {   for(int i = 0; i<volumeNoise; i++)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Fill = new SolidColorBrush(Color.FromArgb((byte)rnd.Next(35, 120), (byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256)));
                rectangle.Width = rectangle.Height = rnd.Next(3, 90);
                cv.Children.Add(rectangle);
                Canvas.SetLeft(rectangle, rnd.Next(0, 250));
                Canvas.SetTop(rectangle, rnd.Next(0, 150));
            }
        
        }
        private void GenerateSymbols(int count) { string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i = 0; i < count; i++)
            {string symbol=alphabet.ElementAt(rnd.Next(0,alphabet.Length)).ToString();
                TextBlock textBlock = new TextBlock();
                textBlock.Text = symbol;
                textBlock.FontSize = rnd.Next(10, 84);
                textBlock.RenderTransform = new RotateTransform(rnd.Next(-45, 45));
                textBlock.Margin = new Thickness(10, 10, 10, 10);
                textBlock.Foreground = new SolidColorBrush(Color.FromArgb((byte)rnd.Next(200, 256), (byte)rnd.Next(0, 254), (byte)rnd.Next(0, 254), (byte)rnd.Next(0, 254)));
                SpCapch.Children.Add(textBlock);
                capcha += symbol;
            }
        }
        private void UpdateCaptcha() 
        {   SpCapch.Children.Clear();
            cv.Children.Clear();
            GenerateSymbols(5);
            GenerateNoise(10);
        }

        private void UpdCapch_Click(object sender, RoutedEventArgs e)
        {
            UpdateCaptcha();
        }

        private void CheckCapch_Click(object sender, RoutedEventArgs e)
        {
            if (capcha == tbCapch.Text.Trim().ToUpper()) { MessageBox.Show("Молодис"); } else { MessageBox.Show("Плохо,лох"); }
        }
    }
}
