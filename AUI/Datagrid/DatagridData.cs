using MMS.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.UI.AUI
{
    public class DatagridData : BaseINotifyPropertyChanged
    {
        private List<DatagridThead> mTheads = null;
        public List<DatagridThead> Theads { get { return this.mTheads; } set { this.mTheads = value; OnPropertyChanged("Theads"); } }

        public List<RowData> mRows = null;
        public List<RowData> Rows 
        { 
            get 
            { 
                return this.mRows; 
            }
            set 
            { 
                this.mRows = value; 
                OnPropertyChanged("Rows"); 
            } 
        }
    }

    public class DatagridThead : BaseINotifyPropertyChanged
    {
        private string mText = String.Empty;
        public string Text { get { return this.mText; } set { this.mText = value; } }

        private int mWidth = 100;
        public int Width { get { return this.mWidth; } set { this.mWidth = value; OnPropertyChanged("Width"); } }
    }

    public class RowData
    {
        public List<RowDataItem> Row { get; set; }
    }

    public class RowDataItem : BaseINotifyPropertyChanged
    {
        private string mText = String.Empty;
        public string Text { get { return this.mText; } set { this.mText = value; OnPropertyChanged("Text"); } }

        private string mColor = "#fff";
        public string Color { get { return this.mColor; } set { this.mColor = value; OnPropertyChanged("Color"); } }

        private string mForeground = "#444";
        public string Foreground { get { return this.mForeground; } set { this.mForeground = value; OnPropertyChanged("Foreground"); } }

        private string mThName = String.Empty;
        public string ThName { get { return this.mThName; } set { this.mThName = value; OnPropertyChanged("ThName"); } }

        public int Width { get; set; }

    }
}
