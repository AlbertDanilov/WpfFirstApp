using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfFirstApp.Models
{
    public class Phone : DependencyObject
    {
        public static readonly DependencyProperty TitleProperty;
        public static readonly DependencyProperty PriceProperty;

        static Phone()
        {
            TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Phone));
            PriceProperty = DependencyProperty.Register("Price", typeof(int), typeof(Phone));
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public int Price
        {
            get { return (int)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
    }
}
