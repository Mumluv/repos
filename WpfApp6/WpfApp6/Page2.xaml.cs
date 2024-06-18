using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
        
    {
        public ObservableCollection<Old> olds {  get; set; }
        public Page2()
        {
            InitializeComponent();
            olds = new ObservableCollection<Old>()
            {
                new Old{Kurs = 1, Discipline = "Programming", Estimate = 5},
                new Old{Kurs = 1, Discipline = "SQL", Estimate = 5},
                new Old{Kurs = 1, Discipline = "GameDev", Estimate = 5},
                new Old{Kurs = 1, Discipline = "Dezine", Estimate = 5},
                new Old{Kurs = 2, Discipline = "Programming", Estimate = 5},
                new Old{Kurs = 2, Discipline = "SQL", Estimate = 5},
                new Old{Kurs = 2, Discipline = "GameDev", Estimate = 5},
                new Old{Kurs = 2, Discipline = "Dezine", Estimate = 5}
            };
            ListOlds.ItemsSource = olds;
        }
        private void ListMarks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
