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
        public ObservableCollection<Phone> phones {  get; set; }

        public MainWindow()
        {
            InitializeComponent();

            phones = new ObservableCollection<Phone>
            {
                new Phone {Id=1, ImagePath="/Images/iphone6s.JPG", Title="iPhone 6S", Company="Apple" },
                new Phone {Id=2, ImagePath="/Images/lumia950.JPG", Title="Lumia 950", Company="Microsoft" },
                new Phone {Id=3, ImagePath="/Images/nexus5x.JPG", Title="Nexus 5X", Company="Google" },
                new Phone {Id=4, ImagePath="/Images/galaxys6.JPG", Title="Galaxy S6", Company="Samsung"}
            };
            phonesList.ItemsSource = phones;
        }

        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone p = (Phone)phonesList.SelectedItem;
            MessageBox.Show(p.Title);
        }
    }
}
