using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessingTools.View
{
    interface IHistogramView
    {
        Chart SourceChartR { get; }
        Chart SourceChartG { get; }
        Chart SourceChartB { get; }

        Chart ResultChartR { get; }
        Chart ResultChartG { get; }
        Chart ResultChartB { get; }
    }
}
