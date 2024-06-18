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
    /// Логика взаимодействия для Page7.xaml 
    /// </summary> 
    public partial class Page7 : Page
    {
        public ObservableCollection<Otchet> otchets { get; set; }

        public Page7()
        {
            InitializeComponent();
            otchets = new ObservableCollection<Otchet>()
            {
                new Otchet() { Otchets = "Проблем со 2 курсом не возникло" },
                new Otchet() { Otchets = "Проблем со 1 курсом не возникло" },
                new Otchet() { Otchets = "Проблем со 3 курсом не возникло" },
                new Otchet() { Otchets = "Проблем со 4 курсом не возникло" }
            };
            ListOtchets.ItemsSource = otchets;
        }
        public void ListOtchets_SelectiomChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
