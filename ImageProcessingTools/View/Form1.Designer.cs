namespace ImageProcessingTools
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend25 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend26 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea27 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend27 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend28 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend29 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend30 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Grayscale_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolBar_panel = new System.Windows.Forms.Panel();
            this.main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.content_splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.image_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.source_pictureBox = new System.Windows.Forms.PictureBox();
            this.result_pictureBox = new System.Windows.Forms.PictureBox();
            this.histogram_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.histogram_source_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.source_R_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.source_G_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.source_B_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.histogram_result_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.result_R_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.result_G_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.result_B_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logMessage_panel = new System.Windows.Forms.Panel();
            this.log_label = new System.Windows.Forms.Label();
            this.logTitle_panel = new System.Windows.Forms.Panel();
            this.logTitle_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BitPlaneSlicing_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BitPlaneSlicing_button = new System.Windows.Forms.Button();
            this.HistogramEqualization_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Thresholding_auto_button = new System.Windows.Forms.Button();
            this.Thresholding_button = new System.Windows.Forms.Button();
            this.Thresholding_threshold_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PowerLaw_r_textBox = new System.Windows.Forms.TextBox();
            this.PowerLaw_c_textBox = new System.Windows.Forms.TextBox();
            this.PowerLaw_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogTransform_button = new System.Windows.Forms.Button();
            this.LogTransform_c_textBox = new System.Windows.Forms.TextBox();
            this.Negative_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Sobel_button = new System.Windows.Forms.Button();
            this.MedianFilter_button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Dilation_button = new System.Windows.Forms.Button();
            this.Erosion_button = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KMeans_k_textBox = new System.Windows.Forms.TextBox();
            this.KMeans_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.儲存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.列印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.預覽列印VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.結束XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.復原UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消復原RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全選AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.內容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.關於AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).BeginInit();
            this.main_splitContainer.Panel1.SuspendLayout();
            this.main_splitContainer.Panel2.SuspendLayout();
            this.main_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.content_splitContainer)).BeginInit();
            this.content_splitContainer.Panel1.SuspendLayout();
            this.content_splitContainer.Panel2.SuspendLayout();
            this.content_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.image_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.source_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_pictureBox)).BeginInit();
            this.histogram_tableLayoutPanel.SuspendLayout();
            this.histogram_source_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.source_R_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_G_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_B_chart)).BeginInit();
            this.histogram_result_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_R_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_G_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_B_chart)).BeginInit();
            this.logMessage_panel.SuspendLayout();
            this.logTitle_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitPlaneSlicing_numericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grayscale_button
            // 
            this.Grayscale_button.Location = new System.Drawing.Point(6, 6);
            this.Grayscale_button.Name = "Grayscale_button";
            this.Grayscale_button.Size = new System.Drawing.Size(75, 23);
            this.Grayscale_button.TabIndex = 4;
            this.Grayscale_button.Text = "Grayscale";
            this.Grayscale_button.UseVisualStyleBackColor = true;
            this.Grayscale_button.Click += new System.EventHandler(this.Grayscale_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolBar_panel
            // 
            this.toolBar_panel.Controls.Add(this.menuStrip1);
            this.toolBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar_panel.Location = new System.Drawing.Point(0, 0);
            this.toolBar_panel.Name = "toolBar_panel";
            this.toolBar_panel.Size = new System.Drawing.Size(1034, 30);
            this.toolBar_panel.TabIndex = 5;
            // 
            // main_splitContainer
            // 
            this.main_splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_splitContainer.Location = new System.Drawing.Point(0, 30);
            this.main_splitContainer.Name = "main_splitContainer";
            // 
            // main_splitContainer.Panel1
            // 
            this.main_splitContainer.Panel1.Controls.Add(this.content_splitContainer);
            this.main_splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // main_splitContainer.Panel2
            // 
            this.main_splitContainer.Panel2.Controls.Add(this.tabControl1);
            this.main_splitContainer.Size = new System.Drawing.Size(1034, 492);
            this.main_splitContainer.SplitterDistance = 704;
            this.main_splitContainer.TabIndex = 6;
            // 
            // content_splitContainer
            // 
            this.content_splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_splitContainer.Location = new System.Drawing.Point(3, 0);
            this.content_splitContainer.Name = "content_splitContainer";
            this.content_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // content_splitContainer.Panel1
            // 
            this.content_splitContainer.Panel1.Controls.Add(this.splitContainer1);
            // 
            // content_splitContainer.Panel2
            // 
            this.content_splitContainer.Panel2.Controls.Add(this.logMessage_panel);
            this.content_splitContainer.Panel2.Controls.Add(this.logTitle_panel);
            this.content_splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.content_splitContainer.Size = new System.Drawing.Size(701, 492);
            this.content_splitContainer.SplitterDistance = 376;
            this.content_splitContainer.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.image_tableLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.histogram_tableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(701, 376);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 0;
            // 
            // image_tableLayoutPanel
            // 
            this.image_tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.image_tableLayoutPanel.ColumnCount = 2;
            this.image_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.image_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.image_tableLayoutPanel.Controls.Add(this.source_pictureBox, 0, 0);
            this.image_tableLayoutPanel.Controls.Add(this.result_pictureBox, 1, 0);
            this.image_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.image_tableLayoutPanel.Name = "image_tableLayoutPanel";
            this.image_tableLayoutPanel.RowCount = 1;
            this.image_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.image_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.image_tableLayoutPanel.Size = new System.Drawing.Size(699, 252);
            this.image_tableLayoutPanel.TabIndex = 0;
            // 
            // source_pictureBox
            // 
            this.source_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.source_pictureBox.Location = new System.Drawing.Point(4, 4);
            this.source_pictureBox.Name = "source_pictureBox";
            this.source_pictureBox.Size = new System.Drawing.Size(342, 244);
            this.source_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.source_pictureBox.TabIndex = 4;
            this.source_pictureBox.TabStop = false;
            // 
            // result_pictureBox
            // 
            this.result_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_pictureBox.Location = new System.Drawing.Point(353, 4);
            this.result_pictureBox.Name = "result_pictureBox";
            this.result_pictureBox.Size = new System.Drawing.Size(342, 244);
            this.result_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.result_pictureBox.TabIndex = 5;
            this.result_pictureBox.TabStop = false;
            // 
            // histogram_tableLayoutPanel
            // 
            this.histogram_tableLayoutPanel.ColumnCount = 2;
            this.histogram_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.histogram_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.histogram_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.histogram_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.histogram_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.histogram_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.histogram_tableLayoutPanel.Controls.Add(this.histogram_source_tableLayoutPanel, 0, 0);
            this.histogram_tableLayoutPanel.Controls.Add(this.histogram_result_tableLayoutPanel, 1, 0);
            this.histogram_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogram_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.histogram_tableLayoutPanel.Name = "histogram_tableLayoutPanel";
            this.histogram_tableLayoutPanel.RowCount = 1;
            this.histogram_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.histogram_tableLayoutPanel.Size = new System.Drawing.Size(699, 116);
            this.histogram_tableLayoutPanel.TabIndex = 0;
            // 
            // histogram_source_tableLayoutPanel
            // 
            this.histogram_source_tableLayoutPanel.ColumnCount = 3;
            this.histogram_source_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.histogram_source_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.histogram_source_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.histogram_source_tableLayoutPanel.Controls.Add(this.source_R_chart, 0, 0);
            this.histogram_source_tableLayoutPanel.Controls.Add(this.source_G_chart, 1, 0);
            this.histogram_source_tableLayoutPanel.Controls.Add(this.source_B_chart, 2, 0);
            this.histogram_source_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogram_source_tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.histogram_source_tableLayoutPanel.Name = "histogram_source_tableLayoutPanel";
            this.histogram_source_tableLayoutPanel.RowCount = 1;
            this.histogram_source_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.histogram_source_tableLayoutPanel.Size = new System.Drawing.Size(343, 110);
            this.histogram_source_tableLayoutPanel.TabIndex = 0;
            // 
            // source_R_chart
            // 
            chartArea25.Name = "ChartArea1";
            this.source_R_chart.ChartAreas.Add(chartArea25);
            this.source_R_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend25.Enabled = false;
            legend25.Name = "Legend1";
            this.source_R_chart.Legends.Add(legend25);
            this.source_R_chart.Location = new System.Drawing.Point(3, 3);
            this.source_R_chart.Name = "source_R_chart";
            series25.ChartArea = "ChartArea1";
            series25.Color = System.Drawing.Color.Red;
            series25.Legend = "Legend1";
            series25.Name = "Series1";
            this.source_R_chart.Series.Add(series25);
            this.source_R_chart.Size = new System.Drawing.Size(108, 104);
            this.source_R_chart.TabIndex = 0;
            this.source_R_chart.Text = "Source_R_chart";
            // 
            // source_G_chart
            // 
            chartArea26.Name = "ChartArea1";
            this.source_G_chart.ChartAreas.Add(chartArea26);
            this.source_G_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend26.Enabled = false;
            legend26.Name = "Legend1";
            this.source_G_chart.Legends.Add(legend26);
            this.source_G_chart.Location = new System.Drawing.Point(117, 3);
            this.source_G_chart.Name = "source_G_chart";
            series26.ChartArea = "ChartArea1";
            series26.Color = System.Drawing.Color.Green;
            series26.Legend = "Legend1";
            series26.Name = "Series1";
            this.source_G_chart.Series.Add(series26);
            this.source_G_chart.Size = new System.Drawing.Size(108, 104);
            this.source_G_chart.TabIndex = 1;
            this.source_G_chart.Text = "chart2";
            // 
            // source_B_chart
            // 
            chartArea27.Name = "ChartArea1";
            this.source_B_chart.ChartAreas.Add(chartArea27);
            this.source_B_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend27.Enabled = false;
            legend27.Name = "Legend1";
            this.source_B_chart.Legends.Add(legend27);
            this.source_B_chart.Location = new System.Drawing.Point(231, 3);
            this.source_B_chart.Name = "source_B_chart";
            series27.ChartArea = "ChartArea1";
            series27.Color = System.Drawing.Color.Blue;
            series27.Legend = "Legend1";
            series27.Name = "Series1";
            this.source_B_chart.Series.Add(series27);
            this.source_B_chart.Size = new System.Drawing.Size(109, 104);
            this.source_B_chart.TabIndex = 2;
            this.source_B_chart.Text = "chart1";
            // 
            // histogram_result_tableLayoutPanel
            // 
            this.histogram_result_tableLayoutPanel.ColumnCount = 3;
            this.histogram_result_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.histogram_result_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.histogram_result_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.histogram_result_tableLayoutPanel.Controls.Add(this.result_R_chart, 0, 0);
            this.histogram_result_tableLayoutPanel.Controls.Add(this.result_G_chart, 1, 0);
            this.histogram_result_tableLayoutPanel.Controls.Add(this.result_B_chart, 2, 0);
            this.histogram_result_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogram_result_tableLayoutPanel.Location = new System.Drawing.Point(352, 3);
            this.histogram_result_tableLayoutPanel.Name = "histogram_result_tableLayoutPanel";
            this.histogram_result_tableLayoutPanel.RowCount = 1;
            this.histogram_result_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.histogram_result_tableLayoutPanel.Size = new System.Drawing.Size(344, 110);
            this.histogram_result_tableLayoutPanel.TabIndex = 1;
            // 
            // result_R_chart
            // 
            chartArea28.Name = "ChartArea1";
            this.result_R_chart.ChartAreas.Add(chartArea28);
            this.result_R_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend28.Enabled = false;
            legend28.Name = "Legend1";
            this.result_R_chart.Legends.Add(legend28);
            this.result_R_chart.Location = new System.Drawing.Point(3, 3);
            this.result_R_chart.Name = "result_R_chart";
            series28.ChartArea = "ChartArea1";
            series28.Color = System.Drawing.Color.Red;
            series28.Legend = "Legend1";
            series28.Name = "Series1";
            this.result_R_chart.Series.Add(series28);
            this.result_R_chart.Size = new System.Drawing.Size(108, 104);
            this.result_R_chart.TabIndex = 0;
            this.result_R_chart.Text = "chart1";
            // 
            // result_G_chart
            // 
            chartArea29.Name = "ChartArea1";
            this.result_G_chart.ChartAreas.Add(chartArea29);
            this.result_G_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend29.Enabled = false;
            legend29.Name = "Legend1";
            this.result_G_chart.Legends.Add(legend29);
            this.result_G_chart.Location = new System.Drawing.Point(117, 3);
            this.result_G_chart.Name = "result_G_chart";
            series29.ChartArea = "ChartArea1";
            series29.Color = System.Drawing.Color.Green;
            series29.Legend = "Legend1";
            series29.Name = "Series1";
            this.result_G_chart.Series.Add(series29);
            this.result_G_chart.Size = new System.Drawing.Size(108, 104);
            this.result_G_chart.TabIndex = 1;
            this.result_G_chart.Text = "chart1";
            // 
            // result_B_chart
            // 
            chartArea30.Name = "ChartArea1";
            this.result_B_chart.ChartAreas.Add(chartArea30);
            this.result_B_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend30.Enabled = false;
            legend30.Name = "Legend1";
            this.result_B_chart.Legends.Add(legend30);
            this.result_B_chart.Location = new System.Drawing.Point(231, 3);
            this.result_B_chart.Name = "result_B_chart";
            series30.ChartArea = "ChartArea1";
            series30.Color = System.Drawing.Color.Blue;
            series30.Legend = "Legend1";
            series30.Name = "Series1";
            this.result_B_chart.Series.Add(series30);
            this.result_B_chart.Size = new System.Drawing.Size(110, 104);
            this.result_B_chart.TabIndex = 2;
            this.result_B_chart.Text = "result_B_chart";
            // 
            // logMessage_panel
            // 
            this.logMessage_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logMessage_panel.Controls.Add(this.log_label);
            this.logMessage_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logMessage_panel.Location = new System.Drawing.Point(5, 35);
            this.logMessage_panel.Name = "logMessage_panel";
            this.logMessage_panel.Size = new System.Drawing.Size(689, 70);
            this.logMessage_panel.TabIndex = 1;
            // 
            // log_label
            // 
            this.log_label.AutoSize = true;
            this.log_label.Location = new System.Drawing.Point(2, 2);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(0, 12);
            this.log_label.TabIndex = 0;
            // 
            // logTitle_panel
            // 
            this.logTitle_panel.Controls.Add(this.logTitle_label);
            this.logTitle_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logTitle_panel.Location = new System.Drawing.Point(5, 5);
            this.logTitle_panel.Name = "logTitle_panel";
            this.logTitle_panel.Size = new System.Drawing.Size(689, 30);
            this.logTitle_panel.TabIndex = 0;
            // 
            // logTitle_label
            // 
            this.logTitle_label.AutoSize = true;
            this.logTitle_label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.logTitle_label.Location = new System.Drawing.Point(6, 11);
            this.logTitle_label.Name = "logTitle_label";
            this.logTitle_label.Size = new System.Drawing.Size(85, 16);
            this.logTitle_label.TabIndex = 0;
            this.logTitle_label.Text = "Log console";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.HistogramEqualization_button);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Negative_button);
            this.tabPage1.Controls.Add(this.Grayscale_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Point Processing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BitPlaneSlicing_numericUpDown);
            this.groupBox5.Controls.Add(this.BitPlaneSlicing_button);
            this.groupBox5.Location = new System.Drawing.Point(7, 399);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "8 Bit-plane Slicing";
            // 
            // BitPlaneSlicing_numericUpDown
            // 
            this.BitPlaneSlicing_numericUpDown.Location = new System.Drawing.Point(8, 21);
            this.BitPlaneSlicing_numericUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.BitPlaneSlicing_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BitPlaneSlicing_numericUpDown.Name = "BitPlaneSlicing_numericUpDown";
            this.BitPlaneSlicing_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.BitPlaneSlicing_numericUpDown.TabIndex = 9;
            this.BitPlaneSlicing_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BitPlaneSlicing_button
            // 
            this.BitPlaneSlicing_button.AutoSize = true;
            this.BitPlaneSlicing_button.Location = new System.Drawing.Point(5, 71);
            this.BitPlaneSlicing_button.Name = "BitPlaneSlicing_button";
            this.BitPlaneSlicing_button.Size = new System.Drawing.Size(102, 23);
            this.BitPlaneSlicing_button.TabIndex = 8;
            this.BitPlaneSlicing_button.Text = "8 Bit-plane Slicing";
            this.BitPlaneSlicing_button.UseVisualStyleBackColor = true;
            this.BitPlaneSlicing_button.Click += new System.EventHandler(this.BitPlaneSlicing_button_Click);
            // 
            // HistogramEqualization_button
            // 
            this.HistogramEqualization_button.AutoSize = true;
            this.HistogramEqualization_button.Location = new System.Drawing.Point(7, 366);
            this.HistogramEqualization_button.Name = "HistogramEqualization_button";
            this.HistogramEqualization_button.Size = new System.Drawing.Size(124, 23);
            this.HistogramEqualization_button.TabIndex = 11;
            this.HistogramEqualization_button.Text = "Histogram Equalization";
            this.HistogramEqualization_button.UseVisualStyleBackColor = true;
            this.HistogramEqualization_button.Click += new System.EventHandler(this.HistogramEqualization_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Thresholding_auto_button);
            this.groupBox3.Controls.Add(this.Thresholding_button);
            this.groupBox3.Controls.Add(this.Thresholding_threshold_textBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(7, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thresholding";
            // 
            // Thresholding_auto_button
            // 
            this.Thresholding_auto_button.Location = new System.Drawing.Point(90, 63);
            this.Thresholding_auto_button.Name = "Thresholding_auto_button";
            this.Thresholding_auto_button.Size = new System.Drawing.Size(75, 23);
            this.Thresholding_auto_button.TabIndex = 3;
            this.Thresholding_auto_button.Text = "auto Thresholding";
            this.Thresholding_auto_button.UseVisualStyleBackColor = true;
            this.Thresholding_auto_button.Click += new System.EventHandler(this.Thresholding_auto_button_Click);
            // 
            // Thresholding_button
            // 
            this.Thresholding_button.Location = new System.Drawing.Point(8, 64);
            this.Thresholding_button.Name = "Thresholding_button";
            this.Thresholding_button.Size = new System.Drawing.Size(75, 23);
            this.Thresholding_button.TabIndex = 2;
            this.Thresholding_button.Text = "Thresholding";
            this.Thresholding_button.UseVisualStyleBackColor = true;
            this.Thresholding_button.Click += new System.EventHandler(this.Thresholding_button_Click);
            // 
            // Thresholding_threshold_textBox
            // 
            this.Thresholding_threshold_textBox.Location = new System.Drawing.Point(94, 21);
            this.Thresholding_threshold_textBox.Name = "Thresholding_threshold_textBox";
            this.Thresholding_threshold_textBox.Size = new System.Drawing.Size(100, 22);
            this.Thresholding_threshold_textBox.TabIndex = 1;
            this.Thresholding_threshold_textBox.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "threshold(閥值):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PowerLaw_r_textBox);
            this.groupBox2.Controls.Add(this.PowerLaw_c_textBox);
            this.groupBox2.Controls.Add(this.PowerLaw_button);
            this.groupBox2.Location = new System.Drawing.Point(7, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 111);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Power-Law Transformations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "r(指數):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "c(倍數):";
            // 
            // PowerLaw_r_textBox
            // 
            this.PowerLaw_r_textBox.Location = new System.Drawing.Point(57, 51);
            this.PowerLaw_r_textBox.Name = "PowerLaw_r_textBox";
            this.PowerLaw_r_textBox.Size = new System.Drawing.Size(100, 22);
            this.PowerLaw_r_textBox.TabIndex = 2;
            this.PowerLaw_r_textBox.Text = "0.7";
            // 
            // PowerLaw_c_textBox
            // 
            this.PowerLaw_c_textBox.Location = new System.Drawing.Point(57, 21);
            this.PowerLaw_c_textBox.Name = "PowerLaw_c_textBox";
            this.PowerLaw_c_textBox.Size = new System.Drawing.Size(100, 22);
            this.PowerLaw_c_textBox.TabIndex = 1;
            this.PowerLaw_c_textBox.Text = "1";
            // 
            // PowerLaw_button
            // 
            this.PowerLaw_button.Location = new System.Drawing.Point(7, 79);
            this.PowerLaw_button.Name = "PowerLaw_button";
            this.PowerLaw_button.Size = new System.Drawing.Size(75, 23);
            this.PowerLaw_button.TabIndex = 0;
            this.PowerLaw_button.Text = "Power-Law";
            this.PowerLaw_button.UseVisualStyleBackColor = true;
            this.PowerLaw_button.Click += new System.EventHandler(this.PowerLaw_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LogTransform_button);
            this.groupBox1.Controls.Add(this.LogTransform_c_textBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Transform";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "c(倍數):";
            // 
            // LogTransform_button
            // 
            this.LogTransform_button.AutoSize = true;
            this.LogTransform_button.Location = new System.Drawing.Point(6, 71);
            this.LogTransform_button.Name = "LogTransform_button";
            this.LogTransform_button.Size = new System.Drawing.Size(86, 23);
            this.LogTransform_button.TabIndex = 7;
            this.LogTransform_button.Text = "Log Transform";
            this.LogTransform_button.UseVisualStyleBackColor = true;
            this.LogTransform_button.Click += new System.EventHandler(this.LogTransform_button_Click);
            // 
            // LogTransform_c_textBox
            // 
            this.LogTransform_c_textBox.Location = new System.Drawing.Point(57, 21);
            this.LogTransform_c_textBox.Name = "LogTransform_c_textBox";
            this.LogTransform_c_textBox.Size = new System.Drawing.Size(100, 22);
            this.LogTransform_c_textBox.TabIndex = 6;
            this.LogTransform_c_textBox.Text = "100";
            // 
            // Negative_button
            // 
            this.Negative_button.Location = new System.Drawing.Point(88, 5);
            this.Negative_button.Name = "Negative_button";
            this.Negative_button.Size = new System.Drawing.Size(75, 23);
            this.Negative_button.TabIndex = 5;
            this.Negative_button.Text = "Negative";
            this.Negative_button.UseVisualStyleBackColor = true;
            this.Negative_button.Click += new System.EventHandler(this.Negative_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Sobel_button);
            this.tabPage2.Controls.Add(this.MedianFilter_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spatial Filtering";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Sobel_button
            // 
            this.Sobel_button.Location = new System.Drawing.Point(7, 37);
            this.Sobel_button.Name = "Sobel_button";
            this.Sobel_button.Size = new System.Drawing.Size(75, 23);
            this.Sobel_button.TabIndex = 1;
            this.Sobel_button.Text = "Sobel";
            this.Sobel_button.UseVisualStyleBackColor = true;
            this.Sobel_button.Click += new System.EventHandler(this.Sobel_button_Click);
            // 
            // MedianFilter_button
            // 
            this.MedianFilter_button.Location = new System.Drawing.Point(7, 7);
            this.MedianFilter_button.Name = "MedianFilter_button";
            this.MedianFilter_button.Size = new System.Drawing.Size(75, 23);
            this.MedianFilter_button.TabIndex = 0;
            this.MedianFilter_button.Text = "Median Filter";
            this.MedianFilter_button.UseVisualStyleBackColor = true;
            this.MedianFilter_button.Click += new System.EventHandler(this.MedianFilter_button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Dilation_button);
            this.tabPage3.Controls.Add(this.Erosion_button);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(316, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Morphology";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Dilation_button
            // 
            this.Dilation_button.Location = new System.Drawing.Point(4, 34);
            this.Dilation_button.Name = "Dilation_button";
            this.Dilation_button.Size = new System.Drawing.Size(75, 23);
            this.Dilation_button.TabIndex = 1;
            this.Dilation_button.Text = "Dilation";
            this.Dilation_button.UseVisualStyleBackColor = true;
            this.Dilation_button.Click += new System.EventHandler(this.Dilation_button_Click);
            // 
            // Erosion_button
            // 
            this.Erosion_button.Location = new System.Drawing.Point(4, 4);
            this.Erosion_button.Name = "Erosion_button";
            this.Erosion_button.Size = new System.Drawing.Size(75, 23);
            this.Erosion_button.TabIndex = 0;
            this.Erosion_button.Text = "Erosion";
            this.Erosion_button.UseVisualStyleBackColor = true;
            this.Erosion_button.Click += new System.EventHandler(this.Erosion_button_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(316, 464);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Segmention";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.KMeans_k_textBox);
            this.groupBox4.Controls.Add(this.KMeans_button);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "k-means";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "k(群數):";
            // 
            // KMeans_k_textBox
            // 
            this.KMeans_k_textBox.Location = new System.Drawing.Point(58, 21);
            this.KMeans_k_textBox.Name = "KMeans_k_textBox";
            this.KMeans_k_textBox.Size = new System.Drawing.Size(100, 22);
            this.KMeans_k_textBox.TabIndex = 1;
            this.KMeans_k_textBox.Text = "3";
            // 
            // KMeans_button
            // 
            this.KMeans_button.Location = new System.Drawing.Point(7, 71);
            this.KMeans_button.Name = "KMeans_button";
            this.KMeans_button.Size = new System.Drawing.Size(75, 23);
            this.KMeans_button.TabIndex = 0;
            this.KMeans_button.Text = "k-means";
            this.KMeans_button.UseVisualStyleBackColor = true;
            this.KMeans_button.Click += new System.EventHandler(this.KMeans_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.說明HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripMenuItem,
            this.開啟OToolStripMenuItem,
            this.toolStripSeparator,
            this.儲存SToolStripMenuItem,
            this.另存新檔AToolStripMenuItem,
            this.toolStripSeparator1,
            this.列印PToolStripMenuItem,
            this.預覽列印VToolStripMenuItem,
            this.toolStripSeparator2,
            this.結束XToolStripMenuItem});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.檔案FToolStripMenuItem.Text = "檔案(&F)";
            // 
            // 新增NToolStripMenuItem
            // 
            this.新增NToolStripMenuItem.Enabled = false;
            this.新增NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripMenuItem.Image")));
            this.新增NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripMenuItem.Name = "新增NToolStripMenuItem";
            this.新增NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新增NToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新增NToolStripMenuItem.Text = "新增(&N)";
            // 
            // 開啟OToolStripMenuItem
            // 
            this.開啟OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripMenuItem.Image")));
            this.開啟OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripMenuItem.Name = "開啟OToolStripMenuItem";
            this.開啟OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開啟OToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開啟OToolStripMenuItem.Text = "開啟(&O)";
            this.開啟OToolStripMenuItem.Click += new System.EventHandler(this.開啟OToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // 儲存SToolStripMenuItem
            // 
            this.儲存SToolStripMenuItem.Enabled = false;
            this.儲存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripMenuItem.Image")));
            this.儲存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripMenuItem.Name = "儲存SToolStripMenuItem";
            this.儲存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.儲存SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.儲存SToolStripMenuItem.Text = "儲存(&S)";
            this.儲存SToolStripMenuItem.Click += new System.EventHandler(this.儲存SToolStripMenuItem_Click);
            // 
            // 另存新檔AToolStripMenuItem
            // 
            this.另存新檔AToolStripMenuItem.Name = "另存新檔AToolStripMenuItem";
            this.另存新檔AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.另存新檔AToolStripMenuItem.Text = "另存新檔(&A)";
            this.另存新檔AToolStripMenuItem.Click += new System.EventHandler(this.另存新檔AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 列印PToolStripMenuItem
            // 
            this.列印PToolStripMenuItem.Enabled = false;
            this.列印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("列印PToolStripMenuItem.Image")));
            this.列印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.列印PToolStripMenuItem.Name = "列印PToolStripMenuItem";
            this.列印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.列印PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.列印PToolStripMenuItem.Text = "列印(&P)";
            // 
            // 預覽列印VToolStripMenuItem
            // 
            this.預覽列印VToolStripMenuItem.Enabled = false;
            this.預覽列印VToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("預覽列印VToolStripMenuItem.Image")));
            this.預覽列印VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.預覽列印VToolStripMenuItem.Name = "預覽列印VToolStripMenuItem";
            this.預覽列印VToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.預覽列印VToolStripMenuItem.Text = "預覽列印(&V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 結束XToolStripMenuItem
            // 
            this.結束XToolStripMenuItem.Enabled = false;
            this.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
            this.結束XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.結束XToolStripMenuItem.Text = "結束(&X)";
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.復原UToolStripMenuItem,
            this.取消復原RToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪下TToolStripMenuItem,
            this.複製CToolStripMenuItem,
            this.貼上PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全選AToolStripMenuItem});
            this.編輯EToolStripMenuItem.Enabled = false;
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.編輯EToolStripMenuItem.Text = "編輯(&E)";
            // 
            // 復原UToolStripMenuItem
            // 
            this.復原UToolStripMenuItem.Name = "復原UToolStripMenuItem";
            this.復原UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.復原UToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.復原UToolStripMenuItem.Text = "復原(&U)";
            // 
            // 取消復原RToolStripMenuItem
            // 
            this.取消復原RToolStripMenuItem.Name = "取消復原RToolStripMenuItem";
            this.取消復原RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.取消復原RToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.取消復原RToolStripMenuItem.Text = "取消復原(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // 剪下TToolStripMenuItem
            // 
            this.剪下TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪下TToolStripMenuItem.Image")));
            this.剪下TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪下TToolStripMenuItem.Name = "剪下TToolStripMenuItem";
            this.剪下TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪下TToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.剪下TToolStripMenuItem.Text = "剪下(&T)";
            // 
            // 複製CToolStripMenuItem
            // 
            this.複製CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("複製CToolStripMenuItem.Image")));
            this.複製CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
            this.複製CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.複製CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.複製CToolStripMenuItem.Text = "複製(&C)";
            // 
            // 貼上PToolStripMenuItem
            // 
            this.貼上PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("貼上PToolStripMenuItem.Image")));
            this.貼上PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
            this.貼上PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼上PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.貼上PToolStripMenuItem.Text = "貼上(&P)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // 全選AToolStripMenuItem
            // 
            this.全選AToolStripMenuItem.Name = "全選AToolStripMenuItem";
            this.全選AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.全選AToolStripMenuItem.Text = "全選(&A)";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂CToolStripMenuItem,
            this.選項OToolStripMenuItem});
            this.工具TToolStripMenuItem.Enabled = false;
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 自訂CToolStripMenuItem
            // 
            this.自訂CToolStripMenuItem.Name = "自訂CToolStripMenuItem";
            this.自訂CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.自訂CToolStripMenuItem.Text = "自訂(&C)";
            // 
            // 選項OToolStripMenuItem
            // 
            this.選項OToolStripMenuItem.Name = "選項OToolStripMenuItem";
            this.選項OToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.選項OToolStripMenuItem.Text = "選項(&O)";
            // 
            // 說明HToolStripMenuItem
            // 
            this.說明HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜尋SToolStripMenuItem,
            this.toolStripSeparator5,
            this.關於AToolStripMenuItem});
            this.說明HToolStripMenuItem.Enabled = false;
            this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            this.說明HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.說明HToolStripMenuItem.Text = "說明(&H)";
            // 
            // 內容CToolStripMenuItem
            // 
            this.內容CToolStripMenuItem.Name = "內容CToolStripMenuItem";
            this.內容CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.內容CToolStripMenuItem.Text = "內容(&C)";
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.索引IToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜尋SToolStripMenuItem
            // 
            this.搜尋SToolStripMenuItem.Name = "搜尋SToolStripMenuItem";
            this.搜尋SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.搜尋SToolStripMenuItem.Text = "搜尋(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // 關於AToolStripMenuItem
            // 
            this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            this.關於AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.關於AToolStripMenuItem.Text = "關於(&A)...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 522);
            this.Controls.Add(this.main_splitContainer);
            this.Controls.Add(this.toolBar_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolBar_panel.ResumeLayout(false);
            this.toolBar_panel.PerformLayout();
            this.main_splitContainer.Panel1.ResumeLayout(false);
            this.main_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).EndInit();
            this.main_splitContainer.ResumeLayout(false);
            this.content_splitContainer.Panel1.ResumeLayout(false);
            this.content_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.content_splitContainer)).EndInit();
            this.content_splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.image_tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.source_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_pictureBox)).EndInit();
            this.histogram_tableLayoutPanel.ResumeLayout(false);
            this.histogram_source_tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.source_R_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_G_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_B_chart)).EndInit();
            this.histogram_result_tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result_R_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_G_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_B_chart)).EndInit();
            this.logMessage_panel.ResumeLayout(false);
            this.logMessage_panel.PerformLayout();
            this.logTitle_panel.ResumeLayout(false);
            this.logTitle_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitPlaneSlicing_numericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Grayscale_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel toolBar_panel;
        private System.Windows.Forms.SplitContainer main_splitContainer;
        private System.Windows.Forms.SplitContainer content_splitContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel image_tableLayoutPanel;
        private System.Windows.Forms.PictureBox source_pictureBox;
        private System.Windows.Forms.PictureBox result_pictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel logMessage_panel;
        private System.Windows.Forms.Panel logTitle_panel;
        private System.Windows.Forms.Label logTitle_label;
        private System.Windows.Forms.Label log_label;
        private System.Windows.Forms.Button Negative_button;
        private System.Windows.Forms.Button LogTransform_button;
        private System.Windows.Forms.TextBox LogTransform_c_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PowerLaw_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PowerLaw_r_textBox;
        private System.Windows.Forms.TextBox PowerLaw_c_textBox;
        private System.Windows.Forms.TableLayoutPanel histogram_tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel histogram_source_tableLayoutPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart source_R_chart;
        private System.Windows.Forms.TableLayoutPanel histogram_result_tableLayoutPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart source_G_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart source_B_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart result_R_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart result_G_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart result_B_chart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Thresholding_button;
        private System.Windows.Forms.TextBox Thresholding_threshold_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button HistogramEqualization_button;
        private System.Windows.Forms.Button MedianFilter_button;
        private System.Windows.Forms.Button Sobel_button;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Erosion_button;
        private System.Windows.Forms.Button Dilation_button;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button KMeans_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KMeans_k_textBox;
        private System.Windows.Forms.Button Thresholding_auto_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BitPlaneSlicing_button;
        private System.Windows.Forms.NumericUpDown BitPlaneSlicing_numericUpDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 儲存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 列印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 預覽列印VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 結束XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 復原UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消復原RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪下TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全選AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選項OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 內容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜尋SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

