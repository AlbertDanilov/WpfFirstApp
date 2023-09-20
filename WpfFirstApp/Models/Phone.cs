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
    public class Phone
    {
        public string Name { get; set; }
        public Company Company { get; set; }
        public decimal Price { get; set; }
    }

    public class Company
    {
        public string Title { get; set; }
    }
}
