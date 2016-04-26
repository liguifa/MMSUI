using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.Amazeui
{
    public class ContentList : Control
    {
        public List<ContentListItem> Source
        {
            get { return (List<ContentListItem>)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(List<ContentListItem>), typeof(ContentList), new PropertyMetadata(null));

        private ItemsControl mMainControl;

        public ContentList()
        {
            this.Style = (Style)Application.Current.Resources["Amazeui_ContentListStyle"];
            this.Loaded += ContentList_Loaded;
        }

        void ContentList_Loaded(object sender, RoutedEventArgs e)
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
