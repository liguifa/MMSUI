using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.Default
{
    public class Explorer : Control
    {
        private TreeView mExplorerTree;

        public Explorer()
        {
            this.Style = (Style)Application.Current.Resources["ExplorerStyle"];
            this.Loaded += Explorer_Loaded;
        }

        void Explorer_Loaded(object sender, RoutedEventArgs e)
        {
            List<ExplorerItem> items = new List<ExplorerItem>();
            ExplorerItem m = new ExplorerItem();
            m.Text = @"VM5310SQL11(SQL Server 2014 - base\prtest)";
            m.Icon = "/MMS.UI;Component/Default/Explorer/Images/Database.ico";
            m.Children = new List<ExplorerItem>();
            ExplorerItem m2 = new ExplorerItem();
            m2.Text = "Documents";
            m2.Icon = "/MMS.UI;Component/Default/Explorer/Images/folder.ico";
            items.Add(m);
            m.Children.Add(m2);
            this.mExplorerTree.ItemsSource = items;
        }

        public override void OnApplyTemplate()
        {
            this.mExplorerTree = (TreeView)this.GetTemplateChild("explorerTree");
            base.OnApplyTemplate();
        }


    }
}
