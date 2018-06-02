using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model
{
    class Grayscale
    {
        /*建構元*/
        private Image _SourceImage;
        private Image _ResultImage;

        /*建構子*/
        public Grayscale(Bitmap bitmap)
        {
            _SourceImage = new Image(bitmap);
            Process();
        }

        /*方法*/
        public Bitmap GetBitmap()
        {
            return _ResultImage.GetBitmap();
        }

        private void Process()
        {
            int Width = _SourceImage.GetBitmap().Width;
            int Height = _SourceImage.GetBitmap().Height;

            int[,,] rgbData = _SourceImage.GetRgbData();

            int[,,] newRGBData = new int[Width, Height, 3];
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    int gray = (rgbData[x, y, 0] + rgbData[x, y, 1] + rgbData[x, y, 2]) / 3;
                    //bimage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                    for (int i = 0; i < 3; i++)
                    {
                        newRGBData[x, y, i] = gray;
                    }
                }
            }

            //setRGBData_unsafe(newRGBData);
            _ResultImage = new Image();
            _ResultImage.SetRgbData(newRGBData);
        }
    }
}
