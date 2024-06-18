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
    /// Логика взаимодействия для Page5.xaml 
    /// </summary> 
    public partial class Page5 : Page
    {
        public ObservableCollection<Students> Students { get; set; }

        public Page5()
        {
            InitializeComponent();
            Students = new ObservableCollection<Students>()
            {
                new Students() {Student = "Макаров Владимир"},
                new Students() {Student = "Кутузов Андрей"},
                new Students() {Student = "Брюшинин Даниил"},
                new Students() {Student = "Колдаев Никита"},
            };
            ListStudents.ItemsSource = Students;
        }
        public void ListStudents_SelectiomChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
