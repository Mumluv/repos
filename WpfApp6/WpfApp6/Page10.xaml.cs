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
    /// Логика взаимодействия для Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        public ObservableCollection<Stats> Stats { get; set; }
        public Page10()
        {
            InitializeComponent();
            Stats = new ObservableCollection<Stats>()
            {
                new Stats() {Srusps = "4.5 По всем предметам у 3 Курса", Srusp = "5 По programming", Poss= "Идеальная", Pos="Идеальная"},
                new Stats() {Srusps = "4.5 По всем предметам у 2 Курса", Srusp = "5 По programming", Poss= "Идеальная", Pos="Идеальная"},
                new Stats() {Srusps = "4.5 По всем предметам у 1 Курса", Srusp = "5 По programming", Poss= "Идеальная", Pos="Идеальная"},
                new Stats() {Srusps = "4.5 По всем предметам у 4 Курса", Srusp = "5 По programming", Poss= "Идеальная", Pos="Идеальная"}
            };
            ListStats.ItemsSource = Stats;
        }
        private void ListStats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
