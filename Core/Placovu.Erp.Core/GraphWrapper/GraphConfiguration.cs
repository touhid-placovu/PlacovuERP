using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Core.GraphWrapper
{
    public class GraphConfiguration
    {
        public string type { get; set; }
        public GraphRootDataSet data { get; set; }
        //public GraphOption options { get; set; }

        public object options { get; set; }
    }
}
