using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.Amazeui
{
    public class Navbar : Control
    {
        public Navbar()
        {
            this.Style = (Style)Application.Current.Resources["Amazeui_NavbarStyle"];
        }
    }
}
