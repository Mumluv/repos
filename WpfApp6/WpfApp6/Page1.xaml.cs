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
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public ObservableCollection<Marks> marks {  get; set; }
        public Page1()
        {
            InitializeComponent();
            marks = new ObservableCollection<Marks>()
            {
                new Marks{Kurs = 3, Discipline = "Programming", Estimate = 5 },
                new Marks{Kurs = 3, Discipline = "SQL", Estimate = 5 },
                new Marks{Kurs = 3, Discipline = "GameDev", Estimate = 5 },
                new Marks{Kurs = 3, Discipline = "Dezine", Estimate = 5 },
            };
            ListMarks.ItemsSource = marks;
        }

        private void ListMarks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
