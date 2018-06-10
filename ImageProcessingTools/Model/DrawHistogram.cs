using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessingTools.Model
{
    class DrawHistogram
    {
        protected Image _SourceImage;
        Chart _chartR;
        Chart _chartG;
        Chart _chartB;

        public DrawHistogram(Bitmap bitmap, Chart chartR, Chart chartG, Chart chartB)
        {
            _SourceImage = new Image(bitmap);
            _chartR = chartR;
            _chartG = chartG;
            _chartB = chartB;

            Draw();
        }

        public Chart GetChart()
        {
            return _chartR;
        }

        public void Draw()
        {
            
            int Width = _SourceImage.GetBitmap().Width;
            int Height = _SourceImage.GetBitmap().Height;

            int[,,] rgbData = _SourceImage.GetRgbData();

            int[,] histogram = new int[256, 3];

            int[,,] newRGBData = new int[Width, Height, 3];
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        histogram[rgbData[x, y, i], i]++;
                    }
                }
            }

            _chartR.Series[0].Points.Clear();
            _chartG.Series[0].Points.Clear();
            _chartB.Series[0].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                _chartR.Series[0].Points.AddXY(i, histogram[i, 0]);
                _chartG.Series[0].Points.AddXY(i, histogram[i, 1]);
                _chartB.Series[0].Points.AddXY(i, histogram[i, 2]);
            }
        }
    }
}
