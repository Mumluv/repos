using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public ObservableCollection<Otz> otzs {  get; set; }
        public Page6()
        {
            InitializeComponent();
            otzs = new ObservableCollection<Otz>()
            {
                new Otz{Otzs = "Крута"},
                new Otz{Otzs = "Вау прикольно"},
                new Otz{Otzs = "Ого крута"},
                new Otz{Otzs = "Обожаю эти курсы"},
            };
            ListOtzs.ItemsSource = otzs;
        }
        public void ListOtzs_SelectiomChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
