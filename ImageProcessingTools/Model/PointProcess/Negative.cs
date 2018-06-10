using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model
{
    class Negative : PointProcess
    {
        public Negative(Bitmap bitmap)
        {
            _SourceImage = new Image(bitmap);
            Process(MakeTable());
        }

        /*方法*/
        private int[] MakeTable()
        {
            int[] table = new int[256];
            for (int i = 0; i < 256; i++)
            {
                table[i] = 255 - i;
            }
            return table;
        }
    }
}
