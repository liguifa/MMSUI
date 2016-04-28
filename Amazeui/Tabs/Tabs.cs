using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace MMS.UI.Amazeui
{
    public class Tabs : Control, IAddChild
    {
        public Tabs()
        {
            this.Style = (Style)Application.Current.Resources["Amazeui_TabsStyle"];
        }

        public void AddChild(object value)
        {
            
        }

        public void AddText(string text)
        {
            
        }
    }
}
