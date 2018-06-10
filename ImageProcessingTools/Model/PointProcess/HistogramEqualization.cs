using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model.PointProcess
{
    class HistogramEqualization : PointProcess
    {
        public HistogramEqualization(Bitmap bitmap)
        {
            _SourceImage = new Image(bitmap);
            Process(MakeTable());
        }

        private int[,] MakeTable()
        {
            int Width = _SourceImage.GetBitmap().Width;
            int Height = _SourceImage.GetBitmap().Height;

            int[,,] rgbData = _SourceImage.GetRgbData();

            int[,] countList = new int[256, 3];

            //掃描像素點統計RGB值
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        countList[rgbData[x, y, i], i]++;
                    }
                }
            }

            float[] countTmp = new float[3];
            int[,] table = new int[256, 3];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    countTmp[j] = countTmp[j] + countList[i, j];
                    table[i, j] = (int)(countTmp[j] / Width / Height * 255);
                }
            }
            return table;
        }
    }
}
