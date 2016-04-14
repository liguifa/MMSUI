using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.AUI
{
    public class Button : System.Windows.Controls.Button
    {
        private System.Windows.Controls.Button mMainBtn;

        public Button()
        {
            this.Style = (Style)Application.Current.Resources["ButtonStyle"];
        }

        public override void OnApplyTemplate()
        {
            this.mMainBtn = (System.Windows.Controls.Button)this.GetTemplateChild("mainBtn");
            this.mMainBtn.DataContext = this;
            base.OnApplyTemplate();
        }
    }
}
