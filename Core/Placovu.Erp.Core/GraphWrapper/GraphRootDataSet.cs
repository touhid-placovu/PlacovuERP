using System.Collections.Generic;

namespace Placovu.Erp.Core.GraphWrapper
{
    public class GraphRootDataSet
    {
        public GraphRootDataSet() {
            labels = new List<string>();
        }
        public List<string> labels { get; set; }
        public List<GraphDataset> datasets { set; get; }
    }
}