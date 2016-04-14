using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace MMS.UI.AUI
{
    public class ConvertFromStatusToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            PointStatus? status = value as PointStatus?;
            switch (status)
            {
                case PointStatus.Future:
                    {
                        return new SolidColorBrush(Colors.Gray);
                    }
                case PointStatus.Past:
                    {
                        return new SolidColorBrush(Colors.Red);
                    }
                case PointStatus.Now:
                    {
                        return new SolidColorBrush(Colors.Red);
                    }
            }
            return new SolidColorBrush(Colors.Gray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
