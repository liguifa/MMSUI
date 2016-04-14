using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MMS.UI.AUI
{
    internal class ConvertFromStatusToThickness : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            PointStatus? status = value as PointStatus?;
            switch (status)
            {
                case PointStatus.Future:
                    {
                        return new Thickness(0, 0, 0, 3);
                    }
                case PointStatus.Past:
                    {
                        return new Thickness(0, 0, 0, 3);
                    }
                case PointStatus.Now:
                    {
                        return new Thickness(0, 0, 0, 3);
                    }
            }
            return new Thickness(0, 0, 0, 3);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
