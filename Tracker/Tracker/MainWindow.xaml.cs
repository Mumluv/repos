using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Tracker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Habits; Integrated Security = True;");
            connection.Open();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand sql = new SqlCommand("select Id from Users where Username = '" + Login.Text + "' and PasswordHash= '" + Password.Text + "';", connection);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                var id = reader[0].ToString();
                reader.Close();
                Habits habits = new Habits();
                habits.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
