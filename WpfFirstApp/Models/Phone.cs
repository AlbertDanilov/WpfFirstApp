using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfFirstApp.Models
{
    public class Phone : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string title;
        private int price;
        private string company;


        public string Company 
        {
            get { return company; }
            set { 
                    company = value;
                    OnPropertyChanged("Company");
            }
        }
     

        public string Title
        {
            get { return title; }
            set { 
                    title = value;
                    OnPropertyChanged("Title");
            }
        }
        public int Price
        {
            get { return price; }
            set {
                    price = value;
                    OnPropertyChanged("Price");  
                }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
