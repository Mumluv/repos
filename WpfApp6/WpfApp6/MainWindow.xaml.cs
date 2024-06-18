using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_3(object sender, RoutedEventArgs e)
        {
            if (Login.Text.Length > 0)
            {
                if (Login.Text == "daniil" && Password.Text == "123")
                {
                    Window1 window1 = new Window1();
                    window1.Show();
                    this.Close();
                } else if (Login.Text == "meneger" && Password.Text == "234")
                {
                    Window2 window2 = new Window2();
                    window2.Show();
                    this.Close();
                } else if (Login.Text == "vova" && Password.Text == "345")
                {
                    Window3 window3 = new Window3();
                    window3.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Проверьте логин или пароль");
                }
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }
        

    }
}