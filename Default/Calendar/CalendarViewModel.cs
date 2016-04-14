using MMS.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MMS.UI.Default
{
    public class CalendarViewModel : BaseINotifyPropertyChanged
    {
        public readonly CalendarHandle CalendarHandle;

        public CalendarViewModel()
        {
            this.CalendarHandle = new CalendarHandle(this);
            this.LeftCommand = new LeftCommand();
            this.RightCommand = new RightCommand();
            this.ShowCommand = new ShowCommand();
            this.TimeList = this.CalendarHandle.GetChooseTimeList();
            this.TimeListTitle = this.CalendarHandle.GetCurrentYearMonth();
            this.DataContext = this;
        }

        private List<ChooseTime> mTimeList = null;
        public List<ChooseTime> TimeList { get { return this.mTimeList; } set { this.mTimeList = value; OnPropertyChanged("TimeList"); } }

        private Visibility mTimeListVisibility = Visibility.Collapsed;
        public Visibility TimeListVisibility { get { return this.mTimeListVisibility; } set { this.mTimeListVisibility = value; OnPropertyChanged("TimeListVisibility"); } }

        private string mTimeListTitle = null;
        public string TimeListTitle { get { return this.mTimeListTitle; } set { this.mTimeListTitle = value; OnPropertyChanged("TimeListTitle"); } }

        private string mChooseTime = DateTime.Now.ToString();
        public string ChooseTime { get { return this.mChooseTime; } set { this.mChooseTime = value; OnPropertyChanged("ChooseTime"); } }

        public LeftCommand LeftCommand { get; set; }

        public RightCommand RightCommand { get; set; }

        public ShowCommand ShowCommand { get; set; }

        public CalendarViewModel DataContext { get; set; }
    }

    public class ChooseTime
    {
        public string Day { get; set; }

        public ChooseCommand ChooseCommand { get; set; }

        public object[] Parameter { get; set; }

        public ChooseTime()
        {
            this.ChooseCommand = new ChooseCommand();
        }
    }

    public class LeftCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            CalendarViewModel calendar = parameter as CalendarViewModel;
            calendar.CalendarHandle.BackMonth();
            calendar.TimeList = calendar.CalendarHandle.GetChooseTimeList();
            calendar.TimeListTitle = calendar.CalendarHandle.GetCurrentYearMonth();
        }
    }

    public class RightCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            CalendarViewModel calendar = parameter as CalendarViewModel;
            calendar.CalendarHandle.NextMonth();
            calendar.TimeList = calendar.CalendarHandle.GetChooseTimeList();
            calendar.TimeListTitle = calendar.CalendarHandle.GetCurrentYearMonth();
        }
    }

    public class ShowCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            CalendarViewModel calendar = parameter as CalendarViewModel;
            calendar.TimeListVisibility = calendar.TimeListVisibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
        }
    }

    public class ChooseCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            string date = (parameter as object[])[0].ToString();
            CalendarViewModel calendar = (parameter as object[])[1] as CalendarViewModel;
            calendar.ChooseTime = date;
        }
    }

}
