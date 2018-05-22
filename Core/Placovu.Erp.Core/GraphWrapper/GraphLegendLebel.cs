using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Core.GraphWrapper
{
    public class GraphLegendLabel
    {
        public GraphLegendLabel()
        {
            usePointStyle = true;
            pointStyle = "round";
            fontSize = 20;
            padding = 20;
            fontFamily = "Arial, sans-serif";
        }
        public bool usePointStyle { get; set; }
        public string pointStyle { get; set; }
        public int fontSize { get; set; }
        public int padding { get; set; }
        public string fontFamily { get; set; }    
    }
}
