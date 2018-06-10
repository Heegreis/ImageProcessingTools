using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model
{
    class Image
    {
        /*建構元*/
        private Bitmap _Bitmap { get; set; }
        //定義RgbData的結構是3維陣列
        private int[,,] RgbData { get; set; }

        /*建構子*/
        public Image()
        {

        }
        public Image(Bitmap bitmap)
        {
            _Bitmap = bitmap;
        }

        public Bitmap GetBitmap()
        {
            return _Bitmap;
        }

        /*用來取得指定bitmap的RgbData，且直接將物件的RgbData更新為此bitmap的RgbData*/
        public int[,,] GetRgbData()
        {
            Bitmap bimage = _Bitmap;

            //鎖住存放圖片的記憶體
            BitmapData bmData = bimage.LockBits(new Rectangle(0, 0, bimage.Width, bimage.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            //取得像點資料的起始位置
            System.IntPtr Scan0 = bmData.Scan0;
            //計算每行像點所佔據的Byte總數
            int ByteNumber_Width = bimage.Width * 3;
            //計算每一行後面幾個Paddind bytes
            int ByteOfSkip = stride - ByteNumber_Width;
            int Height = bimage.Height;
            int Width = bimage.Width;
            RgbData = new int[Width, Height, 3];

            //直接利用指標，將影像資料取出來 BGR
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                for (int y = 0; y < Height; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        RgbData[x, y, 2] = p[0];
                        ++p;
                        RgbData[x, y, 1] = p[0];
                        ++p;
                        RgbData[x, y, 0] = p[0];
                        ++p;
                    }
                    p += ByteOfSkip;
                }
            }
            bimage.UnlockBits(bmData);
            return RgbData;
        }
        /*餵進別的RgbData更新掉物件的的RgbData*/
        public void SetRgbData(int[,,] rgbData)
        {
            int Width = rgbData.GetLength(0);
            int Height = rgbData.GetLength(1);

            _Bitmap = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);

            // Step 1: 先鎖住存放圖片的記憶體
            BitmapData bmData = _Bitmap.LockBits(new Rectangle(0, 0, Width, Height),
                                           ImageLockMode.WriteOnly,
                                           PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;

            // Step 2: 取得像點資料的起始位址
            System.IntPtr Scan0 = bmData.Scan0;

            // 計算每行的像點所佔據的byte 總數
            int ByteNumber_Width = _Bitmap.Width * 3;

            // 計算每一行後面幾個 Padding bytes
            int ByteOfSkip = stride - ByteNumber_Width;


            // Step 3: 直接利用指標, 把影像資料取出來
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                for (int y = 0; y < Height; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        p[0] = (byte)rgbData[x, y, 2]; // 先放 B
                        ++p;
                        p[0] = (byte)rgbData[x, y, 1];  // 再放 G 
                        ++p;
                        p[0] = (byte)rgbData[x, y, 0];  // 最後放 R  
                        ++p;
                    }
                    p += ByteOfSkip; // 跳過剩下的 Padding bytes
                }
            }
            _Bitmap.UnlockBits(bmData);//直接設定本身的Bitmap

            RgbData = rgbData;
        }

    }
}
