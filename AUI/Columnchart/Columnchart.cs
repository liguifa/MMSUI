using MMS.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MMS.UI.AUI
{
    public class Columnchart : Control
    {
        private ItemsControl mScaleItem;
        private ItemsControl mDataItem;

        public Columnchart()
        {
            this.Style = (Style)Application.Current.Resources["AUI_ColumnchartStyle"];
        }

        public override void OnApplyTemplate()
        {
            this.mScaleItem = (ItemsControl)this.GetTemplateChild("scaleItem");
            this.mDataItem = (ItemsControl)this.GetTemplateChild("dataItem");
            this.mScaleItem.ItemsSource = new List<ScaleItem>()
            {
                new ScaleItem()
                {
                    Scale = "10"
                },
                new ScaleItem()
                {
                    Scale = "20"
                },
                new ScaleItem()
                {
                    Scale = "30"
                },
                new ScaleItem()
                {
                    Scale = "40"
                },
            };
            this.mDataItem.ItemsSource = new List<ScaleDateItem>()
           {
               new ScaleDateItem()
               {
                    Color = "#123456",
                    Height = 145,
               },
               new ScaleDateItem()
               {
                    Color = "#123456",
                    Height = 75,
               },
               new ScaleDateItem()
               {
                    Color = "#123456",
                    Height = 245,
               },
           };
            base.OnApplyTemplate();
        }
    }

    public class ScaleItem : BaseINotifyPropertyChanged
    {
        private string mScale = String.Empty;
        public string Scale { get { return this.mScale; } set { this.mScale = String.Format("{0} -", value); OnPropertyChanged("Scale"); } }
    }

    public class ScaleDateItem : BaseINotifyPropertyChanged
    {
        private int mHeight = 100;
        public int Height { get { return this.mHeight; } set { this.mHeight = value; OnPropertyChanged("Height"); } }

        private int mWidth = 50;
        public int Width { get { return this.mWidth; } set { this.mWidth = value; OnPropertyChanged("Width"); } }

        private string mColor = "#3A6506";
        public string Color { get { return this.mColor; } set { this.mColor = value; OnPropertyChanged("Color"); } }
    }
}
