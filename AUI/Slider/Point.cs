using MMS.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MMS.UI.AUI
{
    public class Point : BaseINotifyPropertyChanged
    {
        private string mKey = String.Empty;
        public string Key { get { return this.mKey; } set { this.mKey = value; OnPropertyChanged("Key"); } }

        private PointStatus mStatus = PointStatus.Future;
        public PointStatus Status { get { return this.mStatus; } set { this.mStatus = value; OnPropertyChanged("Status"); } }

        public ICommand ConvertStatusCommand { get; set; }

        public Point(List<Point> points)
        {
            this.ConvertStatusCommand = new ConvertStatusCommand(points);
        }
    }

    public enum PointStatus
    {
        Past,
        Now,
        Future
    }

    public class ConvertStatusCommand : ICommand
    {
        private List<Point> mPoints;

        public ConvertStatusCommand(List<Point> points)
        {
            this.mPoints = points;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            string key = parameter as string;
            bool isPast = false;
            foreach (Point point in this.mPoints)
            {
                if (point.Key.Equals(key))
                {
                    point.Status = PointStatus.Now;
                    isPast = true;
                }
                else if (isPast)
                {
                    point.Status = PointStatus.Future;
                }
                else
                {
                    point.Status = PointStatus.Past;
                }
            }
        }
    }

}
