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

        public ImagePresenter(IImageView view)
        {
            //將View拉進來以便控制
            _imageView = view;
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
    }
}
