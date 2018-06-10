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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Openfile_button = new System.Windows.Forms.Button();
            this.Grayscale_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolBar_panel = new System.Windows.Forms.Panel();
            this.SaveFile_button = new System.Windows.Forms.Button();
            this.main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.content_splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.image_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.source_pictureBox = new System.Windows.Forms.PictureBox();
            this.result_pictureBox = new System.Windows.Forms.PictureBox();
            this.logMessage_panel = new System.Windows.Forms.Panel();
            this.log_label = new System.Windows.Forms.Label();
            this.logTitle_panel = new System.Windows.Forms.Panel();
            this.logTitle_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.histogram_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.histogram_source_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.histogram_result_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.source_R_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.source_G_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.source_B_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.result_R_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.result_G_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.result_B_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.logMessage_panel.SuspendLayout();
            this.logTitle_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.histogram_tableLayoutPanel.SuspendLayout();
            this.histogram_source_tableLayoutPanel.SuspendLayout();
            this.histogram_result_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.source_R_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_G_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_B_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_R_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_G_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_B_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Openfile_button
            // 
            this.Openfile_button.Location = new System.Drawing.Point(3, 3);
            this.Openfile_button.Name = "Openfile_button";
            this.Openfile_button.Size = new System.Drawing.Size(75, 23);
            this.Openfile_button.TabIndex = 2;
            this.Openfile_button.Text = "開啟圖檔";
            this.Openfile_button.UseVisualStyleBackColor = true;
            this.Openfile_button.Click += new System.EventHandler(this.Openfile_button_Click);
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
            this.toolBar_panel.Controls.Add(this.SaveFile_button);
            this.toolBar_panel.Controls.Add(this.Openfile_button);
            this.toolBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar_panel.Location = new System.Drawing.Point(0, 0);
            this.toolBar_panel.Name = "toolBar_panel";
            this.toolBar_panel.Size = new System.Drawing.Size(1027, 30);
            this.toolBar_panel.TabIndex = 5;
            // 
            // SaveFile_button
            // 
            this.SaveFile_button.Location = new System.Drawing.Point(84, 3);
            this.SaveFile_button.Name = "SaveFile_button";
            this.SaveFile_button.Size = new System.Drawing.Size(75, 23);
            this.SaveFile_button.TabIndex = 5;
            this.SaveFile_button.Text = "儲存圖檔";
            this.SaveFile_button.UseVisualStyleBackColor = true;
            this.SaveFile_button.Click += new System.EventHandler(this.SaveFile_button_Click);
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
            this.main_splitContainer.Size = new System.Drawing.Size(1027, 492);
            this.main_splitContainer.SplitterDistance = 713;
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
            this.content_splitContainer.Size = new System.Drawing.Size(710, 492);
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
            this.splitContainer1.Size = new System.Drawing.Size(710, 376);
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
            this.image_tableLayoutPanel.Size = new System.Drawing.Size(708, 252);
            this.image_tableLayoutPanel.TabIndex = 0;
            // 
            // source_pictureBox
            // 
            this.source_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.source_pictureBox.Location = new System.Drawing.Point(4, 4);
            this.source_pictureBox.Name = "source_pictureBox";
            this.source_pictureBox.Size = new System.Drawing.Size(346, 244);
            this.source_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.source_pictureBox.TabIndex = 4;
            this.source_pictureBox.TabStop = false;
            // 
            // result_pictureBox
            // 
            this.result_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_pictureBox.Location = new System.Drawing.Point(357, 4);
            this.result_pictureBox.Name = "result_pictureBox";
            this.result_pictureBox.Size = new System.Drawing.Size(347, 244);
            this.result_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.result_pictureBox.TabIndex = 5;
            this.result_pictureBox.TabStop = false;
            // 
            // logMessage_panel
            // 
            this.logMessage_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logMessage_panel.Controls.Add(this.log_label);
            this.logMessage_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logMessage_panel.Location = new System.Drawing.Point(5, 35);
            this.logMessage_panel.Name = "logMessage_panel";
            this.logMessage_panel.Size = new System.Drawing.Size(698, 70);
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
            this.logTitle_panel.Size = new System.Drawing.Size(698, 30);
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Negative_button);
            this.tabPage1.Controls.Add(this.Grayscale_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(300, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Point Processing";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.LogTransform_button.Location = new System.Drawing.Point(6, 71);
            this.LogTransform_button.Name = "LogTransform_button";
            this.LogTransform_button.Size = new System.Drawing.Size(75, 23);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(300, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.histogram_tableLayoutPanel.Size = new System.Drawing.Size(708, 116);
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
            this.histogram_source_tableLayoutPanel.Size = new System.Drawing.Size(348, 110);
            this.histogram_source_tableLayoutPanel.TabIndex = 0;
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
            this.histogram_result_tableLayoutPanel.Location = new System.Drawing.Point(357, 3);
            this.histogram_result_tableLayoutPanel.Name = "histogram_result_tableLayoutPanel";
            this.histogram_result_tableLayoutPanel.RowCount = 1;
            this.histogram_result_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.histogram_result_tableLayoutPanel.Size = new System.Drawing.Size(348, 110);
            this.histogram_result_tableLayoutPanel.TabIndex = 1;
            // 
            // source_R_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.source_R_chart.ChartAreas.Add(chartArea1);
            this.source_R_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.source_R_chart.Legends.Add(legend1);
            this.source_R_chart.Location = new System.Drawing.Point(3, 3);
            this.source_R_chart.Name = "source_R_chart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.source_R_chart.Series.Add(series1);
            this.source_R_chart.Size = new System.Drawing.Size(109, 104);
            this.source_R_chart.TabIndex = 0;
            this.source_R_chart.Text = "Source_R_chart";
            // 
            // source_G_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.source_G_chart.ChartAreas.Add(chartArea2);
            this.source_G_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.source_G_chart.Legends.Add(legend2);
            this.source_G_chart.Location = new System.Drawing.Point(118, 3);
            this.source_G_chart.Name = "source_G_chart";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.source_G_chart.Series.Add(series2);
            this.source_G_chart.Size = new System.Drawing.Size(109, 104);
            this.source_G_chart.TabIndex = 1;
            this.source_G_chart.Text = "chart2";
            // 
            // source_B_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.source_B_chart.ChartAreas.Add(chartArea3);
            this.source_B_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.source_B_chart.Legends.Add(legend3);
            this.source_B_chart.Location = new System.Drawing.Point(233, 3);
            this.source_B_chart.Name = "source_B_chart";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.source_B_chart.Series.Add(series3);
            this.source_B_chart.Size = new System.Drawing.Size(112, 104);
            this.source_B_chart.TabIndex = 2;
            this.source_B_chart.Text = "chart1";
            // 
            // result_R_chart
            // 
            chartArea4.Name = "ChartArea1";
            this.result_R_chart.ChartAreas.Add(chartArea4);
            this.result_R_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.result_R_chart.Legends.Add(legend4);
            this.result_R_chart.Location = new System.Drawing.Point(3, 3);
            this.result_R_chart.Name = "result_R_chart";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.result_R_chart.Series.Add(series4);
            this.result_R_chart.Size = new System.Drawing.Size(109, 104);
            this.result_R_chart.TabIndex = 0;
            this.result_R_chart.Text = "chart1";
            // 
            // result_G_chart
            // 
            chartArea5.Name = "ChartArea1";
            this.result_G_chart.ChartAreas.Add(chartArea5);
            this.result_G_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.result_G_chart.Legends.Add(legend5);
            this.result_G_chart.Location = new System.Drawing.Point(118, 3);
            this.result_G_chart.Name = "result_G_chart";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.result_G_chart.Series.Add(series5);
            this.result_G_chart.Size = new System.Drawing.Size(109, 104);
            this.result_G_chart.TabIndex = 1;
            this.result_G_chart.Text = "chart1";
            // 
            // result_B_chart
            // 
            chartArea6.Name = "ChartArea1";
            this.result_B_chart.ChartAreas.Add(chartArea6);
            this.result_B_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.result_B_chart.Legends.Add(legend6);
            this.result_B_chart.Location = new System.Drawing.Point(233, 3);
            this.result_B_chart.Name = "result_B_chart";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.result_B_chart.Series.Add(series6);
            this.result_B_chart.Size = new System.Drawing.Size(112, 104);
            this.result_B_chart.TabIndex = 2;
            this.result_B_chart.Text = "result_B_chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 522);
            this.Controls.Add(this.main_splitContainer);
            this.Controls.Add(this.toolBar_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolBar_panel.ResumeLayout(false);
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
            this.logMessage_panel.ResumeLayout(false);
            this.logMessage_panel.PerformLayout();
            this.logTitle_panel.ResumeLayout(false);
            this.logTitle_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.histogram_tableLayoutPanel.ResumeLayout(false);
            this.histogram_source_tableLayoutPanel.ResumeLayout(false);
            this.histogram_result_tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.source_R_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_G_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_B_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_R_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_G_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_B_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Openfile_button;
        private System.Windows.Forms.Button Grayscale_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
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
        private System.Windows.Forms.Button SaveFile_button;
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
    }
}

