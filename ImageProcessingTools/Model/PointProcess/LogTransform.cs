using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model.PointProcess
{
    class LogTransform : PointProcess
    {
        public LogTransform(Bitmap bitmap, int c)
        {
            _SourceImage = new Image(bitmap);
            Process(MakeTable(c));
        }

        private int[] MakeTable(int c)
        {
            int[] table = new int[256];
            for (int i = 0; i < 256; i++)
            {
                table[i] = (int)(c * Math.Log10(1 + i));
            }
            return table;
        }
    }
}
