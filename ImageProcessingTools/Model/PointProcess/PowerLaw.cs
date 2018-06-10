using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model.PointProcess
{
    class PowerLaw : PointProcess
    {
        public PowerLaw(Bitmap bitmap, int c, double r)
        {
            _SourceImage = new Image(bitmap);
            Process(MakeTable(c, r));
        }

        private int[] MakeTable(int c, double r)
        {
            int[] table = new int[256];
            for (int i = 0; i < 256; i++)
            {
                double value = c * (Math.Pow(i, r));
                table[i] = (int)(value > 255 ? 255 : value);
            }
            return table;
        }
    }
}
