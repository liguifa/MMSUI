using MMS.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.UI.AUI
{
    public class BreadcrumbItem : BaseINotifyPropertyChanged
    {
        private string mText = String.Empty;
        public string Text { get { return this.mText; } set { this.mText = value; OnPropertyChanged("Text"); } }
    }
}
