using ImageProcessingTools.Presenter;
using ImageProcessingTools.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessingTools
{
    public partial class Form1 : Form, IImageView, IFileDialogView
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ImagePresenter _imagePresenter { get; set; }
        private FileDialogPresenter _fileDialogPresenter;

        private void Form1_Load(object sender, EventArgs e)
        {
            //綁定一個P
            _imagePresenter = new ImagePresenter(this);
            _fileDialogPresenter = new FileDialogPresenter(this, this);
        }

        /*實作Interface*/
        //IImageView
        public Bitmap SourceBitmap
        {
            //get => (Bitmap)source_pictureBox.Image;
            get => (Bitmap)source_pictureBox.Image;
            set => source_pictureBox.Image = value;
            /*set
            {
                SourceBitmap = value;
                source_pictureBox.Image = SourceBitmap;
            }*/
        }
        public Bitmap ResultBitmap
        {
            get => (Bitmap)result_pictureBox.Image;
            set => result_pictureBox.Image = value;
        }
        //IFileDialogView
        public OpenFileDialog OpenFileDialog { get => openFileDialog1; }
        public SaveFileDialog SaveFileDialog { get => saveFileDialog1; }

        /*public OpenFileDialog OpenFileDialog
        {
            openFileDialog = new OpenFileDialog();
            get => openFileDialog;
        }*/

        private void Openfile_button_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _imagePresenter.OpenImageFile();
            }*/
            //_imagePresenter.OpenImageFile();
            _fileDialogPresenter.OpenImageFile();
            
        }

        private void Grayscale_button_Click(object sender, EventArgs e)
        {
            _imagePresenter.Grayscale();
        }

        private void SaveFile_button_Click(object sender, EventArgs e)
        {
            _fileDialogPresenter.SaveImageFile();
        }

        
    }
}
