using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MMS.UI.AUI
{
    public class CalendarHandle
    {
        private int mMonth;
        private int mYear;
        private readonly CalendarViewModel mCalendarViewModel;

        public CalendarHandle(CalendarViewModel calendarViewModel)
        {
            this.mMonth = DateTime.Now.Month;
            this.mYear = DateTime.Now.Year;
            this.mCalendarViewModel = calendarViewModel;
        }

        private DateTime GetStartDate()
        {
            int startNumOnWeekByMonth = Convert.ToInt32(new DateTime(this.mYear, this.mMonth, 1).DayOfWeek);
            return new DateTime(this.mYear, this.mMonth, 1).AddDays(double.Parse(String.Format("-{0}.0", startNumOnWeekByMonth)));
        }

        private DateTime GetEndDate()
        {
            int nextMonth = this.mMonth < 12 ? this.mMonth + 1 : 1;
            int year = this.mMonth < 12 ? this.mYear : this.mYear + 1;
            int endNumOnWeekByMonth = Convert.ToInt32(new DateTime(year, nextMonth, 1).DayOfWeek);
            return endNumOnWeekByMonth == 0 ? new DateTime(year, nextMonth, 1) : new DateTime(year, nextMonth, 1).AddDays(double.Parse(String.Format("{0}.0", 7 - endNumOnWeekByMonth)));
        }

        public List<ChooseTime> GetChooseTimeList()
        {
            List<ChooseTime> timeList = new List<ChooseTime>();
            DateTime start = this.GetStartDate();
            DateTime end = this.GetEndDate();
            for (int i = 0; start.AddDays(i) < end; i++)
            {
                ChooseTime day = new ChooseTime()
                {
                    Day = start.AddDays(i).Day.ToString("00"),
                    Parameter = new object[] { start.AddDays(i).ToString("", Thread.CurrentThread.CurrentCulture), this.mCalendarViewModel }
                };
                timeList.Add(day);
            };
            return timeList;
        }

        public string GetCurrentYearMonth()
        {
            DateTime date = new DateTime(this.mYear, this.mMonth, 1);
            return String.Format("{0}", date.ToString("y", Thread.CurrentThread.CurrentCulture));
        }

        public void NextMonth()
        {
            if (this.mMonth < 12)
            {
                this.mMonth++;
            }
            else
            {
                this.mMonth = 1;
                this.mYear++;
            }
        }

        public void BackMonth()
        {
            if (this.mMonth > 1)
            {
                this.mMonth--;
            }
            else
            {
                this.mMonth = 12;
                this.mYear--;
            }
        }
    }
}
