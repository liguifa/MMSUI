using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.Amazeui
{
    public class Gallery : Control
    {
        public List<GalleryItem> Source
        {
            get { return (List<GalleryItem>)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(List<GalleryItem>), typeof(Gallery), new PropertyMetadata(null));

        private ItemsControl mMainControl;

        public Gallery()
        {
            this.Style = (Style)Application.Current.Resources["Amazeui_GalleryStyle"];
            this.Loaded += Gallery_Loaded;
        }

        void Gallery_Loaded(object sender, RoutedEventArgs e)
        {
            this.mMainControl.DataContext = this;
            this.mMainControl.SetBinding(ItemsControl.ItemsSourceProperty, "Source");
        }

        public override void OnApplyTemplate()
        {
            this.mMainControl = (ItemsControl)this.GetTemplateChild("mainControl");
            base.OnApplyTemplate();
        }
    }
}
