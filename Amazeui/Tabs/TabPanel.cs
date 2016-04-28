using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.Amazeui
{
    public class TabPanel : Control
    {
        public String Title
        {
            get { return (String)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(String), typeof(TabPanel), new PropertyMetadata(null));

        public String Context
        {
            get { return (String)GetValue(ContextProperty); }
            set { SetValue(ContextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContextProperty =
            DependencyProperty.Register("Context", typeof(String), typeof(TabPanel), new PropertyMetadata(null));


    }
}
