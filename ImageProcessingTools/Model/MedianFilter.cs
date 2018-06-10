using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model
{
    class MedianFilter
    {
        /*建構元*/
        private Image _SourceImage;
        private Image _ResultImage;

        /*建構子*/
        public MedianFilter(Bitmap bitmap)
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
                    //觀察窗排序
                    //Array.Sort(window);
                    for (int i = 0; i < 5; i++)
                    {
                        int[] min = new int[] { i, i, i };
                        for (int j = i + 1; j < 9; j++)
                        {
                            for (int k = 0; k < 3; k++)
                                if (window[j, k] < window[min[k], k])
                                    min[k] = j;
                        }
                        for (int j = 0; j < 3; j++)
                        {
                            if (i != min[j])
                            {
                                int temp = window[i, j];
                                window[i, j] = window[min[j], j];
                                window[min[j], j] = temp;
                            }
                        }
                    }
                    //新圖片設值
                    for (int i = 0; i < 3; i++)
                        newRGBData[x, y, i] = window[4, i];
                }
            }

            //setRGBData_unsafe(newRGBData);
            _ResultImage = new Image();
            _ResultImage.SetRgbData(newRGBData);
        }
    }
}
