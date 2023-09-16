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
using WpfFirstApp.Models;

namespace WpfFirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            usersList.ItemsSource = new List<Person>()
            {
                new Person{Name="Tom", Age=38},
                new Person {Name="Bob", Age=42},
                new Person{Name="Sam", Age=25}
            };

            // устанавливаем отображаемое свойство
            usersList.DisplayMemberPath = "Name";

            usersList.SelectionChanged += usersList_SelectionChanged;
        }

        private void usersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (usersList.SelectedItem is Person person)
            {
                MessageBox.Show(person.Name);
            }
        }
    }
}
