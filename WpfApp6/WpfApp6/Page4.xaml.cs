using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public ObservableCollection<Disciplina> disciplinas { get; set; }
        public Page4()
        {
            InitializeComponent();
            disciplinas = new ObservableCollection<Disciplina>()
            {
                new Disciplina{ Discipline = "Programming"},
                new Disciplina{ Discipline = "SQL"},
                new Disciplina{ Discipline = "GameDev"},
                new Disciplina{ Discipline = "Dezine"},
            };
            ListDisciplin.ItemsSource = disciplinas;
        }
        private void ListMarks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
