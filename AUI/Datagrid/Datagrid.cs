using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.AUI
{
    public class Datagrid : Control
    {
        public DatagridData Source
        {
            get { return (DatagridData)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(DatagridData), typeof(Datagrid), new PropertyMetadata(null));



        public Datagrid()
        {
            this.Style = (Style)Application.Current.Resources["AUI_DatagridStyle"];
            this.Loaded += Datagrid_Loaded;
        }

        void Datagrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this.Source;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}
