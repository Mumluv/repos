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

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            // Получение имени сотрудника из текстового поля
            string employeeName = employeeNameTextBox.Text;

            // Создание нового экземпляра окна с списком сотрудников
            ListWindow listWindow = new ListWindow();

            // Добавление сотрудника в список сотрудников в новом окне
            listWindow.AddEmployee(employeeName);

            // Открытие нового окна
            listWindow.Show();
        }
    }
}
    