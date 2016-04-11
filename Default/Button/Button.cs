using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MMS.UI.Default
{
    public class Button : System.Windows.Controls.Button
    {
        public Button()
        {
            this.Style = (Style)Application.Current.Resources["ButtonStyle"];
        }
    }
}
