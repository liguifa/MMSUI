using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.UI.Amazeui
{
    public class TabItem
    {
        public List<TabHeader> Header { get; set; } 

        public string Context { get; set; }
    }

    public class TabHeader
    {
        public string Title { get; set; }

        public string Background { get; set; }
    }

    public static class StatusColor
    {
        public const string NOTCHECKED = "#EEEEEE";

        public const string ISTCHECKED = "#0e90d2";
    }
}
