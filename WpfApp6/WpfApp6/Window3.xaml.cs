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
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

       private void Button_31(object sender, RoutedEventArgs e)
        {
            frame_3.Navigate(new Page3());
        }


        private void Button_32(object sender, RoutedEventArgs e)
        {
            frame_3.Navigate(new Page8());
        }

        private void Button_33(object sender, RoutedEventArgs e)
        {
            frame_3.Navigate(new Page10());
        }

        private void Button_34(object sender, RoutedEventArgs e)
        {
            frame_3.Navigate(new Page9());
        }


        private void Button_35(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
