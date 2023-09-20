using System;
using System.Collections;
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
using WpfFirstApp.Models;

namespace WpfFirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> phones;

        public MainWindow()
        {
            InitializeComponent();

            phones = new ObservableCollection<string>() { "Apple", "Google", "Samsung" };
            phonesList.ItemsSource = phones;
        }

        public void Button_click(object sender, RoutedEventArgs e)
        {
            phones.Add(phoneTextBox.Text);
        }
    }
}
