using ImageProcessingTools.Presenter;
using ImageProcessingTools.View;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessingTools
{
    public partial class Form1 : Form, IImageView, IFileDialogView, IHistogramView
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
            _imagePresenter = new ImagePresenter(this, this);
            _fileDialogPresenter = new FileDialogPresenter(this, this);
        }

        /*實作Interface*/
        //IImageView
        public Bitmap SourceBitmap
        {
            //get => (Bitmap)source_pictureBox.Image;
            get => (Bitmap)source_pictureBox.Image;
            set
            {
                source_pictureBox.Image = value;
                SourceHistogram();
            }
            /*set
{
   SourceBitmap = value;
   source_pictureBox.Image = SourceBitmap;
}*/
        }
        public Bitmap ResultBitmap
        {
            get => (Bitmap)result_pictureBox.Image;
            set
            {
                result_pictureBox.Image = value;
                ResultHistogram();
            }
        }
        //IFileDialogView
        public OpenFileDialog OpenFileDialog { get => openFileDialog1; }
        public SaveFileDialog SaveFileDialog { get => saveFileDialog1; }
        //IHistogramView
        public Chart SourceChartR { get => source_R_chart; }
        public Chart SourceChartG { get => source_G_chart; }
        public Chart SourceChartB { get => source_B_chart; }
        public Chart ResultChartR { get => result_R_chart; }
        public Chart ResultChartG { get => result_G_chart; }
        public Chart ResultChartB { get => result_B_chart; }

        private void Openfile_button_Click(object sender, EventArgs e)
        {
            _fileDialogPresenter.OpenImageFile();
        }

        private void SaveFile_button_Click(object sender, EventArgs e)
        {
            _fileDialogPresenter.SaveImageFile();
        }

        private void SourceHistogram()
        {
            _imagePresenter.SourseHistogram();
        }

        private void ResultHistogram()
        {
            _imagePresenter.ResultHistogram();
        }

        private void Grayscale_button_Click(object sender, EventArgs e)
        {
            _imagePresenter.Grayscale();
        }

        private void Negative_button_Click(object sender, EventArgs e)
        {
            _imagePresenter.Negative();
        }

        private void LogTransform_button_Click(object sender, EventArgs e)
        {
            _imagePresenter.LogTransform(int.Parse(LogTransform_c_textBox.Text.ToString()));
        }

        private void PowerLaw_button_Click(object sender, EventArgs e)
        {
            /*int c = 1;
            double r = 0.7;
            try
            {*/
                int c = int.Parse(PowerLaw_c_textBox.Text.ToString());
                double r = double.Parse(PowerLaw_r_textBox.Text.ToString());
            /*}
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            _imagePresenter.PowerLaw(c, r);
        }

        private void Thresholding_button_Click(object sender, EventArgs e)
        {
            _imagePresenter.Thresholding(int.Parse(Thresholding_threshold_textBox.Text.ToString()));
        }
    }
}
