using System;
using System.Collections;
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
        public Phone MyPhone { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            MyPhone = new Phone
            {
                Name = "Nokia",
                Company = new Company { Title = "Microsoft" },
                Price = 1000
            };
            this.DataContext = MyPhone;
        }
    }
}
