namespace Placovu.Erp.Core.GraphWrapper
{
    public class GraphLegend
    {
        public GraphLegend() {
            fontSize = 20;
            display = true;
        }
        public bool display { get; set; }
        public int fontSize { get; set; }

        public GraphLegendLabel labels { get; set; }
    }
}
