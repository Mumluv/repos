using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
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
using System.Xml;

namespace Tracker
{
    public partial class Habits : Window
    {
        private const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Habits";
        private SqlConnection connection;

        public ObservableCollection<string> Days { get; set; }
        public ObservableCollection<Habit> Habibi { get; set; }
        public Habit SelectedHabit { get; set; }

        public Habits()
        {
            InitializeComponent();
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            Days = new ObservableCollection<string>();
            for (int i = 1; i <= 31; i++)
            {
                Days.Add(i.ToString());
            }

            Habibi = new ObservableCollection<Habit>();
            LoadHabits();

            DataContext = this;
        }

        private void AddHabit_Click(object sender, RoutedEventArgs e)
        {
            string habitName = HabitInput.Text.Trim();
            if (!string.IsNullOrEmpty(habitName))
            {
                var habit = new Habit { Name = habitName, Days = new ObservableCollection<HabitDay>() };
                for (int i = 0; i < 31; i++)
                {
                    habit.Days.Add(new HabitDay { Day = i + 1, IsCompleted = false });
                }
                Habibi.Add(habit);
                SaveHabitToDatabase(habit);
                HabitInput.Clear();
            }
        }

        private void SaveHabitToDatabase(Habit habit)
        {
            using (var command = new SqlCommand("INSERT INTO Habits (Name) VALUES (@name); SELECT SCOPE_IDENTITY();", connection))
            {
                command.Parameters.AddWithValue("@name", habit.Name);
                long habitId = Convert.ToInt64(command.ExecuteScalar());
                habit.Id = habitId;

                foreach (var day in habit.Days)
                {
                    using (var dayCommand = new SqlCommand("INSERT INTO HabitDays (HabitId, Day, IsCompleted) VALUES (@habitId, @day, @isCompleted)", connection))
                    {
                        dayCommand.Parameters.AddWithValue("@habitId", habitId);
                        dayCommand.Parameters.AddWithValue("@day", day.Day);
                        dayCommand.Parameters.AddWithValue("@isCompleted", day.IsCompleted);
                        dayCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        
        private void SaveHabits_Click(object sender, RoutedEventArgs e)
        {
            foreach (var habit in Habibi)
            {
                if (habit.Id == 0)
                {
                    SaveHabitToDatabase(habit);
                }
                else
                {
                    using (var command = new SqlCommand("UPDATE Habits SET Name = @name WHERE Id = @habitId", connection))
                    {
                        command.Parameters.AddWithValue("@name", habit.Name);
                        command.Parameters.AddWithValue("@habitId", habit.Id);
                        command.ExecuteNonQuery();
                    }

                    foreach (var day in habit.Days)
                    {
                        using (var command = new SqlCommand("UPDATE HabitDays SET IsCompleted = @isCompleted WHERE HabitId = @habitId AND Day = @day", connection))
                        {
                            command.Parameters.AddWithValue("@isCompleted", day.IsCompleted);
                            command.Parameters.AddWithValue("@habitId", habit.Id);
                            command.Parameters.AddWithValue("@day", day.Day);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }

            MessageBox.Show("Привычки успешно сохранены.", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LoadHabits()
        {
            var command = new SqlCommand("SELECT * FROM Habits", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var habit = new Habit
                    {
                        Id = Convert.ToInt64(reader["Id"]),
                        Name = (string)reader["Name"],
                        Days = new ObservableCollection<HabitDay>()
                    };
                    Habibi.Add(habit);
                }
            }

            foreach (var habit in Habibi)
            {
                LoadHabitDays(habit);
            }
        }

        private void LoadHabitDays(Habit habit)
        {
            var command = new SqlCommand("SELECT * FROM HabitDays WHERE HabitId = @habitId", connection);
            command.Parameters.AddWithValue("@habitId", habit.Id);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int day = (int)reader["Day"];
                    bool isCompleted = (bool)reader["IsCompleted"];
                    habit.Days.Add(new HabitDay { Day = day, IsCompleted = isCompleted });
                }
            }
        }

        private void ClearHabitsList()
        {
            foreach (var habit in Habibi)
            {
                using (var command = new SqlCommand("DELETE FROM HabitDays WHERE HabitId = @habitId", connection))
                {
                    command.Parameters.AddWithValue("@habitId", habit.Id);
                    command.ExecuteNonQuery();
                }
                using (var command = new SqlCommand("DELETE FROM Habits WHERE Id = @habitId", connection))
                {
                    command.Parameters.AddWithValue("@habitId", habit.Id);
                    command.ExecuteNonQuery();
                }
            }

            Habibi.Clear();
        }

        private void ClearHabitListButton_Click(object sender, RoutedEventArgs e)
        {
            ClearHabitsList();
        }

        private void HabitList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SelectedHabit = (sender as System.Windows.Controls.ListBox).SelectedItem as Habit;
            if (SelectedHabit != null)
            {
                TrackerGrid.DataContext = null;
                TrackerGrid.DataContext = this;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            connection.Close();
        }

        public class Habit : INotifyPropertyChanged
        {
            private long id;
            private string name;
            private ObservableCollection<HabitDay> days;

            public long Id
            {
                get => id;
                set
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }

            public string Name
            {
                get => name;
                set
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }

            public ObservableCollection<HabitDay> Days
            {
                get => days;
                set
                {
                    days = value;
                    OnPropertyChanged("Days");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public class HabitDay : INotifyPropertyChanged
        {
            private int day;
            private bool isCompleted;

            public int Day
            {
                get => day;
                set
                {
                    day = value;
                    OnPropertyChanged("Day");
                }
            }

            public bool IsCompleted
            {
                get => isCompleted;
                set
                {
                    isCompleted = value;
                    OnPropertyChanged("IsCompleted");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}




