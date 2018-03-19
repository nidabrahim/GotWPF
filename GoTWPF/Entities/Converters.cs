using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace GoTWPF.Entities
{

    [ValueConversion(typeof(Point[]), typeof(Geometry))]
    public class PointsToPathConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (((string)value).Length > 0)
            {
                return Geometry.Parse(((string)value));
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion
    }
    [ValueConversion(typeof(string), typeof(SolidColorBrush))]
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == "Green")
            {
                return new SolidColorBrush(Colors.Green);
            }
            else if (value == "#D2691E")
            {
                return (SolidColorBrush)(new BrushConverter().ConvertFrom("#D2691E"));
            }
            else if (value == "Red")
            {
                return new SolidColorBrush(Colors.Red);
            }
            else if (value == "Aqua")
            {
                return new SolidColorBrush(Colors.Yellow);
            }
            else if (value == "#1E90FF")
            {
                return (SolidColorBrush)(new BrushConverter().ConvertFrom("#1E90FF"));
            }
            else
            {
                return new SolidColorBrush(Colors.Red);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class TextToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (((string)value) == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (((Boolean)value) == true)
            {
                return "Y";
            }
            else
            {
                return "N";
            }
        }
    }

}
