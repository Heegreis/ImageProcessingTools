using ImageProcessingTools.Presenter;
using ImageProcessingTools.View;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessingTools
{
    public partial class Form1 : Form, IImageView, IFileDialogView, IHistogramView, ILogView
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ImagePresenter _imagePresenter { get; set; }
        private FileDialogPresenter _fileDialogPresenter;
        private LogPresenter _logPresenter;

        private void Form1_Load(object sender, EventArgs e)
        {
            //綁定一個P
            _imagePresenter = new ImagePresenter(this, this);
            _fileDialogPresenter = new FileDialogPresenter(this, this);
            _logPresenter = new LogPresenter(this);
        }

        /*實作Interface*/
        //IImageView
        public Bitmap SourceBitmap
        {
            get => (Bitmap)source_pictureBox.Image;
            set
            {
                source_pictureBox.Image = value;
                SourceHistogram();
            }
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
        //ILogView
        public string Log
        {
            get => log_label.Text.ToString(); set => log_label.Text = value;
        }

        /*Button*/
        //標準menu選項
        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileDialogPresenter.OpenImageFile();
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileDialogPresenter.SaveImageFile();
        }

        //顯示與更新直方圖
        private void SourceHistogram()
        {
            _imagePresenter.SourseHistogram();
        }

        private void ResultHistogram()
        {
            _imagePresenter.ResultHistogram();
        }

        /*執行影像處理功能*/
        private void Grayscale_button_Click(object sender, EventArgs e)
        {
            _logPresenter.TimeCountStart();
            _imagePresenter.Grayscale();
            _logPresenter.TimeStopToLog();
        }

        private void Negative_button_Click(object sender, EventArgs e)
        {
            _logPresenter.TimeCountStart();
            _imagePresenter.Negative();
            _logPresenter.TimeStopToLog();
        }

        private void LogTransform_button_Click(object sender, EventArgs e)
        {
            _logPresenter.TimeCountStart();
            _imagePresenter.LogTransform(int.Parse(LogTransform_c_textBox.Text.ToString()));
            _logPresenter.TimeStopToLog();
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
            _logPresenter.TimeCountStart();
            _imagePresenter.PowerLaw(c, r);
            _logPresenter.TimeStopToLog();
        }

        private void Thresholding_auto_button_Click(object sender, EventArgs e)
        {
            _logPresenter.TimeCountStart();
            _imagePresenter.Thresholding();
            _logPresenter.TimeStopToLog();
        }

        private void Thresholding_button_Click(object sender, EventArgs e)
        {
            _logPresenter.TimeCountStart();
            _imagePresenter.Thresholding(int.Parse(Thresholding_threshold_textBox.Text.ToString()));
            _logPresenter.TimeStopToLog();
        }

        private void HistogramEqualization_button_Click(object sender, EventArgs e)
        {
            _logPresenter.TimeCountStart();
            _imagePresenter.HistogramEqualization();
            _logPresenter.TimeStopToLog();
        }

        private void MedianFilter_button_Click(object sender, EventArgs e)
        {
            _logPresenter.TimeCountStart();
            _imagePresenter.MedianFilter();
            _logPresenter.TimeStopToLog();
        }

        private void Sobel_button_Click(object sender, EventArgs e)
        {
            _imagePresenter.Sobel();
        }

        private void Erosion_button_Click(object sender, EventArgs e)
        {
            _imagePresenter.Erosion();
        }

        private void Dilation_button_Click(object sender, EventArgs e)
        {
            _imagePresenter.Dilation();
        }

        private void KMeans_button_Click(object sender, EventArgs e)
        {
            _imagePresenter.KMeans(int.Parse(KMeans_k_textBox.Text.ToString()));
        }

        private void BitPlaneSlicing_button_Click(object sender, EventArgs e)
        {
            int bit = Convert.ToInt32(BitPlaneSlicing_numericUpDown.Value);

            _imagePresenter.BitPlaneSlicing(bit);
        }

    }
}
