using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model.PointProcess
{
    class Thresholding : PointProcess
    {
        public Thresholding(Bitmap bitmap, int t)
        {
            _SourceImage = new Image(bitmap);
            Process(MakeTable(t));
        }

        private int[] MakeTable(int t)
        {
            int[] table = new int[256];
            for (int i = 0; i < 256; i++)
            {
                table[i] = i > t ? 255 : 0;
            }
            return table;
        }
    }
}
