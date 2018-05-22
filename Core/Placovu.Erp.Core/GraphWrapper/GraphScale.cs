using System.Collections.Generic;

namespace Placovu.Erp.Core.GraphWrapper
{
    public class GraphScale
    {
        public GraphScale() {
            xAxes = new List<object> {
                new {
                    gridLines = new
                    {
                        zeroLineWidth = 1,
                        zeroLineColor = "#000000",
                        drawTicks = true,
                        tickMarkLength = 25,
                        drawBorder = true,
                        drawOnChartArea = true,

                    },
                    ticks = new
                    {
                        fontSize = 18,
                        padding = 40,
                        fontColor = "#000000",
                    }
                }                
            };
            yAxes = new List<object> {
                new {
                    gridLines = new
                    {
                        zeroLineWidth = 1,
                        zeroLineColor = "#000000",
                        drawTicks = true,
                        tickMarkLength = 15,
                        drawBorder = true,
                        drawOnChartArea = true,
                    },
                    ticks = new
                    {
                        fontSize = 18,
                        padding = 20,
                        fontColor = "#000000",
                    }
                }
            };
        }
        public object xAxes { get; set; }
        public object yAxes { get; set; }
    }
}
