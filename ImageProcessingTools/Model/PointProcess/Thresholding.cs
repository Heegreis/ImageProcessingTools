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
        //auto average Thresholding
        public Thresholding(Bitmap bitmap)
        {
            _SourceImage = new Image(bitmap);
            Process(MakeTable());
        }

        //self set t
        public Thresholding(Bitmap bitmap, int t)
        {
            _SourceImage = new Image(bitmap);
            Process(MakeTable(t));
        }
        
        private int[] MakeTable()
        {
            int Width = _SourceImage.GetBitmap().Width;
            int Height = _SourceImage.GetBitmap().Height;

            int[,,] rgbData = _SourceImage.GetRgbData();

            int graySum = 0;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    graySum = graySum + rgbData[x, y, 0];
                }
            }

            int t = graySum / (Width * Height);

            int[] table = new int[256];
            for (int i = 0; i < 256; i++)
            {
                table[i] = i > t ? 255 : 0;
            }
            return table;
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
