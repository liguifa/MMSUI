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
    public class Header : Control
    {
        private Button mLeftButton;
        private Button mRightButton;
        private Label mTitleBar;

        public ICommand LeftCommand
        {
            get { return (ICommand)GetValue(LeftCommandProperty); }
            set { SetValue(LeftCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftCommandProperty =
            DependencyProperty.Register("LeftCommand", typeof(ICommand), typeof(Header), new PropertyMetadata(null));

        public object LeftCommandParameter
        {
            get { return (object)GetValue(LeftCommandParameterProperty); }
            set { SetValue(LeftCommandParameterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftCommandParameter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftCommandParameterProperty =
            DependencyProperty.Register("LeftCommandParameter", typeof(object), typeof(Header), new PropertyMetadata(null));

        public ICommand RightCommand
        {
            get { return (ICommand)GetValue(RightCommandProperty); }
            set { SetValue(RightCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RightCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RightCommandProperty =
            DependencyProperty.Register("RightCommand", typeof(ICommand), typeof(Header), new PropertyMetadata(null));

        public ICommand RightCommandParameter
        {
            get { return (ICommand)GetValue(RightCommandParameterProperty); }
            set { SetValue(RightCommandParameterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RightCommandParameter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RightCommandParameterProperty =
            DependencyProperty.Register("RightCommandParameter", typeof(int), typeof(Header), new PropertyMetadata(null));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Header), new PropertyMetadata(String.Empty));

        public bool IsTop
        {
            get { return (bool)GetValue(IsTopProperty); }
            set { SetValue(IsTopProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsTop.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsTopProperty =
            DependencyProperty.Register("IsTop", typeof(bool), typeof(Header), new PropertyMetadata(false));



        public Header()
        {
            this.Style = (Style)Application.Current.Resources["Amazeui_HeaderStyle"];
            this.Loaded += Header_Loaded;
        }

        void Header_Loaded(object sender, RoutedEventArgs e)
        {
            this.mRightButton.DataContext = this;
            this.mRightButton.SetBinding(Button.CommandProperty, "RightCommand");
            this.mRightButton.SetBinding(Button.CommandParameterProperty, "RightCommandParameter");
            this.mLeftButton.DataContext = this;
            this.mLeftButton.SetBinding(Button.CommandProperty, "LeftCommand");
            this.mLeftButton.SetBinding(Button.CommandParameterProperty, "LeftCommandParameter");
            this.mTitleBar.DataContext = this;
            this.mTitleBar.SetBinding(Label.ContentProperty, "Title");
        }

        public override void OnApplyTemplate()
        {
            this.mLeftButton = (Button)this.GetTemplateChild("leftBtn");
            this.mRightButton = (Button)this.GetTemplateChild("rightBtn");
            this.mTitleBar = (Label)this.GetTemplateChild("titleBar");
            base.OnApplyTemplate();
        }
    }
}
