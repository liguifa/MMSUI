using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.Default
{
    public class Calendar : System.Windows.Controls.Control
    {
        private Grid mCalendar;

        public Calendar()
        {
            this.Style = (Style)Application.Current.Resources["CalendarStyle"];
        }

        public override void OnApplyTemplate()
        {
            this.mCalendar = (Grid)this.GetTemplateChild("calendar");
            this.mCalendar.DataContext = new CalendarViewModel();
            base.OnApplyTemplate();
        }
    }
}
