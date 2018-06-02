using ImageProcessingTools.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingTools.Presenter
{
    class FileDialogPresenter
    {
        private readonly IFileDialogView _IFileDialogView;
        private readonly IImageView _IImageView;

        public FileDialogPresenter(IFileDialogView fileDialogView, IImageView imageView)
        {
            _IFileDialogView = fileDialogView;
            _IImageView = imageView;
        }

        public void OpenImageFile()
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "C:\\";
            if (_IFileDialogView.OpenFileDialog.ShowDialog() ==  DialogResult.OK)
            {
                //Console.WriteLine(_imageView.OpenFileDialog.FileName);
                //Bitmap bitmap;
                _IImageView.SourceBitmap = (Bitmap)System.Drawing.Image.FromFile(_IFileDialogView.OpenFileDialog.FileName);
                //bitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
