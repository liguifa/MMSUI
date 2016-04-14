using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace MMS.UI.AUI
{
    public class Carousel : Control
    {
        private ItemsControl mMainItem;
        private ItemsControl mControlPoint;
        private int mFrom = 0;

        public Carousel()
        {
            this.Style = (Style)Application.Current.Resources["AUI_CarouselStyle"];
            this.Loaded += Carousel_Loaded;
        }

        void Carousel_Loaded(object sender, RoutedEventArgs e)
        {
            this.mMainItem.Width = this.Width * 4;
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Animation);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            dispatcherTimer.Start();
        }

        private void Animation(object sender, EventArgs e)
        {
            this.mMainItem.RenderTransform = new TranslateTransform();
            DoubleAnimation animation = new DoubleAnimation();
            animation.By = 0 - this.Width;
            animation.From = this.mFrom;
            animation.Duration = new Duration(TimeSpan.FromSeconds(1));
            Storyboard storyboard = new Storyboard();
            Storyboard.SetTarget(animation, this.mMainItem);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.X)"));
            storyboard.Children.Add(animation);
            storyboard.Begin();
            this.mFrom -= (int)this.Width;
            if ((0 - this.mFrom) >= (this.mMainItem.Width / 2))
            {
                this.mFrom = 0;
            }
        }

        public override void OnApplyTemplate()
        {
            this.mMainItem = (ItemsControl)this.GetTemplateChild("itemControl");
            this.mControlPoint = (ItemsControl)this.GetTemplateChild("controlPoint");
            this.mControlPoint.ItemsSource = this.mMainItem.ItemsSource = new List<ImageInfo>()
            {
                new ImageInfo(){ Url = "image_2.png",Width = this.Width,Height=this.Height},
                new ImageInfo(){ Url = "image_4.png",Width = this.Width,Height=this.Height},
                new ImageInfo(){ Url = "image_2.png",Width = this.Width,Height=this.Height},
                new ImageInfo(){ Url = "image_4.png",Width = this.Width,Height=this.Height},
            };
            base.OnApplyTemplate();
        }
    }

    public class ImageInfo
    {
        public string Url { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }
    }
}
