using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.AUI
{
    public class Breadcrumb : Control
    {
        private ItemsControl mItemControl;

        public List<BreadcrumbItem> Source
        {
            get { return (List<BreadcrumbItem>)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(List<BreadcrumbItem>), typeof(Breadcrumb), new PropertyMetadata(null));

        public Breadcrumb()
        {
            this.Style = (Style)Application.Current.Resources["BreadcrumbStyle"];
            this.Loaded += Breadcrumb_Loaded;
        }

        void Breadcrumb_Loaded(object sender, RoutedEventArgs e)
        {
            this.mItemControl.DataContext = this;
            this.mItemControl.SetBinding(ItemsControl.ItemsSourceProperty, "Source");
        }

        public override void OnApplyTemplate()
        {
            this.mItemControl = (ItemsControl)this.GetTemplateChild("itemControl");
            base.OnApplyTemplate();
        }
    }
}
