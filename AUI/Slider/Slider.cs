using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.AUI
{
    public class Slider : Control
    {
        private ItemsControl mMainControl;

        public List<Point> Source
        {
            get { return (List<Point>)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(List<Point>), typeof(Slider), new PropertyMetadata(null));



        public Slider()
        {
            this.Style = (Style)Application.Current.Resources["AUI_SliderStyle"];
        }

        public override void OnApplyTemplate()
        {
            this.mMainControl = (ItemsControl)this.GetTemplateChild("mainControl");
            this.mMainControl.DataContext = this;
            this.mMainControl.SetBinding(ItemsControl.ItemsSourceProperty, "Source");
            base.OnApplyTemplate();
        }
    }
}
