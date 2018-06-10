using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model
{
    class Sobel
    {
        /*建構元*/
        private Image _SourceImage;
        private Image _ResultImage;

        /*建構子*/
        public Sobel(Bitmap bitmap)
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

            int[] VerticalSobelOperator = new int[] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
            int[] HorizontalSobelOperator = new int[] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };

            int[,,] newRGBData = new int[Width, Height, 3];
            for (int y = 1; y < Height - 1; y++)
            {
                for (int x = 1; x < Width - 1; x++)
                {
                    //觀察窗3*3設值
                    int[,] window = new int[9, 3];
                    int windowKey = 0;
                    for (int yy = y - 1; yy < y + 2; yy++)
                    {
                        for (int xx = x - 1; xx < x + 2; xx++)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                window[windowKey, i] = rgbData[xx, yy, i];
                            }
                            windowKey++;
                        }
                    }
                    //Mask運算
                    for (int i = 0; i < 3; i++)
                    {
                        int VerticalSobel = 0;
                        int HorizontalSobel = 0;
                        for (int j = 0; j < 9; j++)
                        {
                            VerticalSobel += VerticalSobelOperator[j] * window[j, i];
                            HorizontalSobel += HorizontalSobelOperator[j] * window[j, i];
                        }

                        newRGBData[x, y, i] = (int)Math.Sqrt(Math.Pow(VerticalSobel, 2) + Math.Pow(HorizontalSobel, 2));
                    }
                }
            }

            //setRGBData_unsafe(newRGBData);
            _ResultImage = new Image();
            _ResultImage.SetRgbData(newRGBData);
        }
    }
}
