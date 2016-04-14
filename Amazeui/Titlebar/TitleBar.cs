using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MMS.UI.Amazeui
{
    public class TitleBar : Control
    {
        private Label mTitleLabel;
        private Button mMoreButton;

        public ICommand MoreCommand
        {
            get { return (ICommand)GetValue(MoreCommandProperty); }
            set { SetValue(MoreCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MoreCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MoreCommandProperty =
            DependencyProperty.Register("MoreCommand", typeof(int), typeof(TitleBar), new PropertyMetadata(null));

        public object MoreCommandParameter
        {
            get { return (object)GetValue(MoreCommandParameterProperty); }
            set { SetValue(MoreCommandParameterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MoreCommandParameter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MoreCommandParameterProperty =
            DependencyProperty.Register("MoreCommandParameter", typeof(object), typeof(TitleBar), new PropertyMetadata(null));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(TitleBar), new PropertyMetadata(String.Empty));

        public TitleBar()
        {
            this.Style = (Style)Application.Current.Resources["Amazeui_TitleBarStyle"];
        }

        public override void OnApplyTemplate()
        {
            this.mTitleLabel = (Label)this.GetTemplateChild("titleLabel");
            this.mMoreButton = (Button)this.GetTemplateChild("moreButton");
            this.mTitleLabel.DataContext = this;
            this.mTitleLabel.SetBinding(Label.ContentProperty, "Title");
            this.mMoreButton.DataContext = this;
            this.mMoreButton.SetBinding(Button.CommandParameterProperty, "MoreCommandParameter");
            this.mMoreButton.SetBinding(Button.CommandProperty, "MoreCommand");
            base.OnApplyTemplate();
        }
    }
}
