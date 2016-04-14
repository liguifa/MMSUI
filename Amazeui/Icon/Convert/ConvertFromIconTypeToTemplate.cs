using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace MMS.UI.Amazeui
{
    public class ConvertFromIconTypeToTemplate : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IconType? type = value as IconType?;
            //switch (type)
            //{
            //    case IconType.Index:
            //        {
            //            //return new ControlTemplate(typeof(Button)) { Template = new TemplateContent() };
            //        }
            //}
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
