using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.Default
{
    public class Connection : System.Windows.Window
    {
        private Button mCloseBtn;
        private DockPanel mTitleBorder;
        private Button mConnectBtn;
        private Button mCancelBtn;

        public delegate void OKClick();
        public event OKClick OKButton_Click;

        public Connection()
        {
            this.Style = (Style)Application.Current.Resources["ConnectionStyle"];
            this.Loaded += Connection_Loaded;
        }

        void Connection_Loaded(object sender, RoutedEventArgs e)
        {
            this.mCloseBtn.Click += mCloseBtn_Click;
            this.mTitleBorder.MouseMove += mTitleBorder_MouseMove;
            this.mConnectBtn.Click += mConnectBtn_Click;
            this.mCancelBtn.Click += mCancelBtn_Click;
        }

        void mCancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void mConnectBtn_Click(object sender, RoutedEventArgs e)
        {
            this.OKButton_Click();
            this.Close();
        }

        public override void OnApplyTemplate()
        {
            this.mCloseBtn = (Button)this.GetTemplateChild("closeBtn");
            this.mTitleBorder = (DockPanel)this.GetTemplateChild("titleBorder");
            this.mConnectBtn = (Button)this.GetTemplateChild("connectBtn");
            this.mCancelBtn = (Button)this.GetTemplateChild("cancelBtn");
            base.OnApplyTemplate();
        }

        void mTitleBorder_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void mCloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
