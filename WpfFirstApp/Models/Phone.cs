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
        public int Id { get; set; }
        public string Title { get; set; } // модель телефона
        public string Company { get; set; } // производитель
        public string ImagePath { get; set; } // путь к изображению
    }

    public class Company
    {
        public string Title { get; set; }
    }
}
