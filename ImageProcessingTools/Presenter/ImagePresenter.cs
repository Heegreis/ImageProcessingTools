using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessingTools.Model;
using ImageProcessingTools.Model.PointProcess;
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

        public void SourseHistogram()
        {
            DrawHistogram sourceHistogram = new DrawHistogram(_imageView.SourceBitmap, _histogramView.SourceChartR, _histogramView.SourceChartG, _histogramView.SourceChartB);
        }
        public void ResultHistogram()
        {
            DrawHistogram resultHistogram = new DrawHistogram(_imageView.ResultBitmap, _histogramView.ResultChartR, _histogramView.ResultChartG, _histogramView.ResultChartB);
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
        public void Thresholding()
        {
            _imageView.ResultBitmap = new Thresholding(_imageView.SourceBitmap).GetBitmap();
        }
        public void Thresholding(int t)
        {
            _imageView.ResultBitmap = new Thresholding(_imageView.SourceBitmap, t).GetBitmap();
        }
        public void HistogramEqualization()
        {
            _imageView.ResultBitmap = new HistogramEqualization(_imageView.SourceBitmap).GetBitmap();
        }
        public void MedianFilter()
        {
            _imageView.ResultBitmap = new MedianFilter(_imageView.SourceBitmap).GetBitmap();
        }
        public void Sobel()
        {
            _imageView.ResultBitmap = new Sobel(_imageView.SourceBitmap).GetBitmap();
        }
        public void Erosion()
        {
            _imageView.ResultBitmap = new Erosion(_imageView.SourceBitmap).GetBitmap();
        }
        public void Dilation()
        {
            _imageView.ResultBitmap = new Dilation(_imageView.SourceBitmap).GetBitmap();
        }
        public void KMeans(int k)
        {
            _imageView.ResultBitmap = new KMeans(_imageView.SourceBitmap, k).GetBitmap();
        }
    }
}
