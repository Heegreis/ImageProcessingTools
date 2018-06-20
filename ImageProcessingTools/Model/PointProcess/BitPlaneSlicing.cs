using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model.PointProcess
{
    class BitPlaneSlicing : PointProcess
    {
        public BitPlaneSlicing(Bitmap bitmap, int bit)
        {
            _SourceImage = new Image(bitmap);
            Process(MakeTable(bit));
        }

        private int[] MakeTable(int bit)
        {
            int[] table = new int[256];
            int filter = (int)Math.Pow(2, (bit - 1));
            /*for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1)
                {
                    filter += bits[i] * (int)Math.Pow(2, i);
                }
            }*/

            for (int i = 0; i < 256; i++)
            {
                table[i] = (i & filter) == filter ? 255 : 0;
            }
            return table;
        }
    }
}
