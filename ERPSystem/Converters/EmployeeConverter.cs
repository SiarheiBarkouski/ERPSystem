using ERPSystem.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ERPSystem.Converters
{
    class EmployeeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                Employee x = (Employee)value;
                return String.Format($"Id: {x.Id}\n" +
                                     $"Birthday: {x.Birth.ToShortDateString()}\n" +
                                     $"Address: {x.Address}");
            }
            else return null; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
