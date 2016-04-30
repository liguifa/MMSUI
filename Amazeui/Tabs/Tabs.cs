using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace MMS.UI.Amazeui
{
    public class Tabs : ItemsControl
    {
        private List<string> mContexts;
        private ItemsControl mTitleControl;

        public Tabs()
        {
            this.Style = (Style)Application.Current.Resources["Amazeui_TabsStyle"];
            this.Loaded += Tabs_Loaded;
        }

        private void Tabs_Loaded(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();
            tab.Header = new List<TabHeader>();
            foreach (var item in this.Items)
            {
                if (item is TabPanel)
                {
                    TabPanel panel = (TabPanel)item;
                    tab.Header.Add(new TabHeader() { Title = panel.Title, Background = panel.IsChecked ? StatusColor.ISTCHECKED : StatusColor.NOTCHECKED });
                    tab.Context = panel.Context;
                }
            }
            this.DataContext = tab;
        }

        public override void OnApplyTemplate()
        {
            this.mTitleControl = (ItemsControl)this.GetTemplateChild("titleControl");
            base.OnApplyTemplate();
        }
    }
}
