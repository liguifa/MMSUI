using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.UI.Default
{
    public class ExplorerItem
    {
        public string Text { get; set; }

        public string Icon { get; set; }

        public List<ExplorerItem> Children { get; set; }
    }
}
