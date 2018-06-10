using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model
{
    class KMeans
    {
        /*建構元*/
        private Image _SourceImage;
        private Image _ResultImage;

        /*建構子*/
        public KMeans(Bitmap bitmap, int k)
        {
            _SourceImage = new Image(bitmap);
            Process(k);
        }

        /*方法*/
        public Bitmap GetBitmap()
        {
            return _ResultImage.GetBitmap();
        }

        private void Process(int k)
        {
            int Width = _SourceImage.GetBitmap().Width;
            int Height = _SourceImage.GetBitmap().Height;

            int[,,] rgbData = _SourceImage.GetRgbData();

            //設定 K 與 隨機初始值u(顏色)
            //u[k, R、G、B]
            int[,] u = new int[k, 3];
            
            //學長的種子點
            for (int i = 0; i < k; i++)
            {
                u[i, 0] = ((255 / k) * i);
                u[i, 1] = ((255 / k) * i);
                u[i, 2] = ((255 / k) * i);
            }

            //遞迴->統計、歸類->新群
            KmeansData kmeansdata = new KmeansData(rgbData, k, u, Width, Height);

            int[,,] newRGBData = new int[Width, Height, 3];
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        //新圖片設值
                        //黑白
                        /*newRGBData[x, y, i] = kmeansdata.u[kmeansdata.group[x, y]]; //u[group[x,y]]*/
                        //彩色
                        newRGBData[x, y, i] = kmeansdata.u[kmeansdata.group[x, y], i];
                    }
                }
            }

            //setRGBData_unsafe(newRGBData);
            _ResultImage = new Image();
            _ResultImage.SetRgbData(newRGBData);
        }
    }
}
