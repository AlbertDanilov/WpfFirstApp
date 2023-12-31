﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFirstApp.Models
{
    class PersonModel : IDataErrorInfo
    {
        public string this[string columnName] 
        { 
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Age":
                        if ((Age < 0) || (Age > 100))
                        {
                            error = "Возраст должен быть больше 0 и меньше 100";
                        }
                        break;
                    case "Name":
                        //Обработка ошибок для свойства Name
                        break;
                    case "Position":
                        //Обработка ошибок для свойства Position
                        break;
                }
                return error;
            }
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public string Error => throw new NotImplementedException();
    }
}
