using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model
{
    class PointProcess
    {
        /*建構元*/
        protected Image _SourceImage;
        protected Image _ResultImage;

        /*方法*/
        public Bitmap GetBitmap()
        {
            return _ResultImage.GetBitmap();
        }

        protected void Process(int[] table)
        {
            int Width = _SourceImage.GetBitmap().Width;
            int Height = _SourceImage.GetBitmap().Height;

            int[,,] rgbData = _SourceImage.GetRgbData();

            int[,,] newRGBData = new int[Width, Height, 3];
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        newRGBData[x, y, i] = table[rgbData[x, y, i]];
                    }
                }
            }

            _ResultImage = new Image();
            _ResultImage.SetRgbData(newRGBData);
        }
    }
}
