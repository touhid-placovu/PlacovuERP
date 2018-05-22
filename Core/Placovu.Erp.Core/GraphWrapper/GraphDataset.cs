using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Placovu.Erp.Core.GraphWrapper
{
    public class GraphDataset
    {
        public string label { get; set; }

        public List<decimal> data { get; set; }

        public bool fill { get; set; }

        public int borderWidth { get; set; }

        public string backgroundColor { get; set; }

        public int pointRadius { get; set; }

        public int pointBorderWidth { get; set; }

        public int pointHoverRadius { get; set; }

        public bool showLine { get; set; }

        public int lineTension { get; set; }

        public string pointBorderColor { get; set; }

        public string borderColor { get; set; }

        public string pointBackgroundColor { get; set; }

        public string backgroundFill { get; set; }
    }    
}