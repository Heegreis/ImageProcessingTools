using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Model
{
    class KmeansData
    {
        private int[,,] rgbData;
        private int k;
        public int[,] u;
        private int Width;
        private int Height;
        //紀錄圖片上每個點分別屬於哪個群
        public int[,] group;
        //累加此群值的集合[x,0~2]RGB、[x,3]統計群裡點的個數
        private int[,] coSet;

        private int count;

        public KmeansData()
        {
            //空白建構元
            this.rgbData = new int[0, 0, 0];
            this.k = 0;
            this.u = new int[0, 0];
            this.Width = 0;
            this.Height = 0;
            this.group = new int[0, 0];
            this.coSet = new int[0, 0];

            this.count = 0;
        }

        public KmeansData(int[,,] rgbData, int k, int[,] u, int Width, int Height)
        {
            this.count = 0;

            this.rgbData = rgbData;
            this.k = k;
            this.u = u;
            this.Width = Width;
            this.Height = Height;
            this.group = new int[Width, Height];
            this.coSet = new int[k, 4];

            cluster();
        }

        private void cluster()
        {
            bool isQuit = false;
            do
            {
                for (int y = 0; y < Height; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        //分類點的群
                        double minDest = Math.Sqrt(Math.Pow(rgbData[x, y, 0] - this.u[0, 0], 2) + Math.Pow(rgbData[x, y, 1] - this.u[0, 1], 2) + Math.Pow(rgbData[x, y, 2] - this.u[0, 2], 2));
                        group[x, y] = 0;

                        for (int j = 1; j < this.k; j++)
                        {
                            if ((Math.Sqrt(Math.Pow(rgbData[x, y, 0] - this.u[j, 0], 2) + Math.Pow(rgbData[x, y, 1] - this.u[j, 1], 2) + Math.Pow(rgbData[x, y, 2] - this.u[j, 2], 2))) < minDest)
                            {
                                minDest = Math.Sqrt(Math.Pow(rgbData[x, y, 0] - this.u[j, 0], 2) + Math.Pow(rgbData[x, y, 1] - this.u[j, 1], 2) + Math.Pow(rgbData[x, y, 2] - this.u[j, 2], 2));
                                group[x, y] = j;
                            }
                        }
                        //累加值
                        coSet[group[x, y], 0] += rgbData[x, y, 0];
                        coSet[group[x, y], 1] += rgbData[x, y, 1];
                        coSet[group[x, y], 2] += rgbData[x, y, 2];
                        //計算個數
                        coSet[group[x, y], 3]++;

                    }
                }
                //上一個群中心
                int[,] pre_u = new int[this.k, 3];
                Array.Copy(this.u, pre_u, this.u.Length);

                //計算新中心
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < this.k; j++)
                    {
                        //待處理問題:有時選的初始點會造成某一群會沒有所屬的點，變成除以0的錯誤
                        this.u[j, i] = coSet[j, i] / coSet[j, 3];
                    }
                }

                //印出檢查
                Console.Write("pre:");
                for (int i = 0; i < this.k; i++)
                {
                    Console.Write("[" + pre_u[i, 0] + ",");
                    Console.Write(pre_u[i, 1] + ",");
                    Console.Write(pre_u[i, 2] + "]");
                }
                Console.Write("\n");

                Console.Write("u:");
                for (int i = 0; i < this.k; i++)
                {
                    Console.Write("[" + this.u[i, 0] + ",");
                    Console.Write(this.u[i, 1] + ",");
                    Console.Write(this.u[i, 2] + "]");
                }
                Console.Write("\n");

                count++;
                Console.Write(count + "\n");

                //比較新舊群中心
                bool u_equal = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < this.k; j++)
                    {
                        if (this.u[j, i] != pre_u[j, i])
                        {
                            u_equal = false;
                            break;
                        }
                    }
                }
                if (u_equal)
                    isQuit = true;
            } while (count < 10 && !isQuit);
        }
    }
}
