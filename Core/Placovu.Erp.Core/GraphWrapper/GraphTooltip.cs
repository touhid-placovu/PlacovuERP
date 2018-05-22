using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Core.GraphWrapper
{
    public class GraphTooltip
    {
        public GraphTooltip() {
            enabled = true;
            mode = "nearest";
            backgroundColor = "#F7BB29";
            bodyFontColor = "#000";
            titleFontColor = "#000";
            caretPadding = 10;
            xPadding = 10;
            yPadding = 10;            
            position = "nearest";
            titleFontSize = 15;
            bodyFontSize = 15;
            titleFontFamily = "Raleway";
            bodyFontFamily = "Raleway";
            titleSpacing = 8;
            bodySpacing = 8;
            displayColors = false;
        }
        public bool enabled { get; set; }
        public string mode { get; set; }
        //public bool intersect { get; set; }
        public string backgroundColor { get; set; }
        public string bodyFontColor { get; set; }
        public string titleFontColor { get; set; }
        public int caretPadding { get; set; }
        public int xPadding { get; set; }
        public int yPadding { get; set; }
        public string position { get; set; }
        public int titleFontSize { get; set; }
        public int bodyFontSize { get; set; }
        public string titleFontFamily { get; set; }
        public string bodyFontFamily { get; set; }
        public int titleSpacing { get; set; }
        public int bodySpacing { get; set; }
        public bool displayColors { get; set; }

        public object custom { get; set; }
        //public List<string> callbacks { get; set; }
    }
}
