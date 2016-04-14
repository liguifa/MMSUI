using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MMS.UI.AUI
{
    public class Calendar : System.Windows.Controls.Control
    {
        private Grid mCalendar;
        private Grid mTitleBar;

        public Calendar()
        {
            this.Style = (Style)Application.Current.Resources["AUI_CalendarStyle"];
        }

        public override void OnApplyTemplate()
        {
            this.mCalendar = (Grid)this.GetTemplateChild("calendar");
            this.mCalendar.DataContext = new CalendarViewModel();
            base.OnApplyTemplate();
        }
    }
}
