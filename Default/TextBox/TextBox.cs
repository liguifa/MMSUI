using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MMS.UI.Default
{
    public class TextBox : System.Windows.Controls.TextBox
    {
        private System.Windows.Controls.TextBox mTextBox;

        public new string Text { get { return this.mTextBox.Text; } set { this.mTextBox.Text = value; } }

        public string Error { get; set; }

        public TextBox()
        {
            this.Style = (Style)Application.Current.Resources["TextBoxStyle"];
        }

        public override void OnApplyTemplate()
        {
            this.mTextBox = (System.Windows.Controls.TextBox)this.GetTemplateChild("textBox");
            base.OnApplyTemplate();
        }
    }
}
