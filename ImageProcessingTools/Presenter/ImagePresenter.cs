using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessingTools.Model;
using ImageProcessingTools.View;

namespace ImageProcessingTools.Presenter
{
    class ImagePresenter
    {
        private readonly IImageView _imageView;
        private readonly IHistogramView _histogramView;

        public ImagePresenter(IImageView view, IHistogramView histogramView)
        {
            //將View拉進來以便控制
            _imageView = view;
            _histogramView = histogramView;
        }

        public void OpenImageFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "C:\\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Console.WriteLine(_imageView.OpenFileDialog.FileName);
                //Bitmap bitmap;
                _imageView.SourceBitmap = (Bitmap)System.Drawing.Image.FromFile(openFileDialog.FileName);
                //bitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);
            }
            
            
        }
        public void Grayscale()
        {
            _imageView.ResultBitmap = new Grayscale(_imageView.SourceBitmap).GetBitmap();
        }
        public void Negative()
        {
            _imageView.ResultBitmap = new Negative(_imageView.SourceBitmap).GetBitmap();
        }
        public void LogTransform(int c)
        {
            _imageView.ResultBitmap = new LogTransform(_imageView.SourceBitmap, c).GetBitmap();
        }
        public void PowerLaw(int c, double r)
        {
            _imageView.ResultBitmap = new PowerLaw(_imageView.SourceBitmap, c, r).GetBitmap();
        }
        public void SourseHistogram()
        {
            DrawHistogram sourceHistogram = new DrawHistogram(_imageView.SourceBitmap, _histogramView.SourceChartR, _histogramView.SourceChartG, _histogramView.SourceChartB);
        }
        public void ResultHistogram()
        {
            DrawHistogram resultHistogram = new DrawHistogram(_imageView.ResultBitmap, _histogramView.ResultChartR, _histogramView.ResultChartG, _histogramView.ResultChartB);
        }
    }
}
