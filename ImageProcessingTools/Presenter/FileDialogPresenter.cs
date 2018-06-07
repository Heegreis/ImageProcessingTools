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
        private readonly IFileDialogView _fileDialogView;
        private readonly IImageView _imageView;

        public FileDialogPresenter(IFileDialogView fileDialogView, IImageView imageView)
        {
            _fileDialogView = fileDialogView;
            _imageView = imageView;
        }

        public void OpenImageFile()
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "C:\\";
            if (_fileDialogView.OpenFileDialog.ShowDialog() ==  DialogResult.OK)
            {
                //Console.WriteLine(_imageView.OpenFileDialog.FileName);
                //Bitmap bitmap;
                _imageView.SourceBitmap = (Bitmap)System.Drawing.Image.FromFile(_fileDialogView.OpenFileDialog.FileName);
                //bitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);
            }
        }

        public void SaveImageFile()
        {
            _fileDialogView.SaveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            _fileDialogView.SaveFileDialog.Title = "儲存圖片";
            _fileDialogView.SaveFileDialog.ShowDialog();

            if (_fileDialogView.SaveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)_fileDialogView.SaveFileDialog.OpenFile();

                switch (_fileDialogView.SaveFileDialog.FilterIndex)
                {
                    case 1:
                        _imageView.ResultBitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        _imageView.ResultBitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        _imageView.ResultBitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                fs.Close();
            }
        }
    }
}
