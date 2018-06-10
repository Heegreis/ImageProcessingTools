using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model
{
    class Dilation
    {
        /*建構元*/
        private Image _SourceImage;
        private Image _ResultImage;

        /*建構子*/
        public Dilation(Bitmap bitmap)
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
            for (int y = 1; y < Height - 1; y++)
            {
                for (int x = 1; x < Width - 1; x++)
                {
                    //觀察窗3*3判斷值
                    //int[] window = new int[9];
                    int windowKey = 0;
                    bool isDilation = false;
                    for (int yy = y - 1; yy < y + 2; yy++)
                    {
                        for (int xx = x - 1; xx < x + 2; xx++)
                        {
                            //window[windowKey] = rgbData[xx, yy, 0];   
                            windowKey++;
                            if (windowKey == 5)
                                continue;
                            if (rgbData[xx, yy, 0] == 255)
                            {
                                isDilation = true;
                                break;
                            }
                        }
                    }

                    if (isDilation)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            newRGBData[x, y, i] = 255;
                        }
                    }
                }
            }

            //setRGBData_unsafe(newRGBData);
            _ResultImage = new Image();
            _ResultImage.SetRgbData(newRGBData);
        }
    }
}
