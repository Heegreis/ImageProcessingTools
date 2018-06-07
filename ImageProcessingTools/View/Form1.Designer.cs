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
            this.Openfile_button = new System.Windows.Forms.Button();
            this.Grayscale_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveFile_button = new System.Windows.Forms.Button();
            this.main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.content_splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.image_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.source_pictureBox = new System.Windows.Forms.PictureBox();
            this.result_pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.logTitle_label = new System.Windows.Forms.Label();
            this.logTitle_panel = new System.Windows.Forms.Panel();
            this.logMessage_panel = new System.Windows.Forms.Panel();
            this.log_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.SuspendLayout();
            this.image_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.source_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_pictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.logTitle_panel.SuspendLayout();
            this.logMessage_panel.SuspendLayout();
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
            this.Grayscale_button.Location = new System.Drawing.Point(165, 3);
            this.Grayscale_button.Name = "Grayscale_button";
            this.Grayscale_button.Size = new System.Drawing.Size(75, 23);
            this.Grayscale_button.TabIndex = 4;
            this.Grayscale_button.Text = "灰階化";
            this.Grayscale_button.UseVisualStyleBackColor = true;
            this.Grayscale_button.Click += new System.EventHandler(this.Grayscale_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Grayscale_button);
            this.panel1.Controls.Add(this.SaveFile_button);
            this.panel1.Controls.Add(this.Openfile_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 30);
            this.panel1.TabIndex = 5;
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
            // 
            // main_splitContainer.Panel2
            // 
            this.main_splitContainer.Panel2.Controls.Add(this.tabControl1);
            this.main_splitContainer.Size = new System.Drawing.Size(810, 492);
            this.main_splitContainer.SplitterDistance = 660;
            this.main_splitContainer.TabIndex = 6;
            // 
            // content_splitContainer
            // 
            this.content_splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_splitContainer.Location = new System.Drawing.Point(0, 0);
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
            this.content_splitContainer.Size = new System.Drawing.Size(660, 492);
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
            this.splitContainer1.Size = new System.Drawing.Size(660, 376);
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
            this.image_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.image_tableLayoutPanel.Size = new System.Drawing.Size(658, 252);
            this.image_tableLayoutPanel.TabIndex = 0;
            // 
            // source_pictureBox
            // 
            this.source_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.source_pictureBox.Location = new System.Drawing.Point(4, 4);
            this.source_pictureBox.Name = "source_pictureBox";
            this.source_pictureBox.Size = new System.Drawing.Size(321, 244);
            this.source_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.source_pictureBox.TabIndex = 4;
            this.source_pictureBox.TabStop = false;
            // 
            // result_pictureBox
            // 
            this.result_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_pictureBox.Location = new System.Drawing.Point(332, 4);
            this.result_pictureBox.Name = "result_pictureBox";
            this.result_pictureBox.Size = new System.Drawing.Size(322, 244);
            this.result_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.result_pictureBox.TabIndex = 5;
            this.result_pictureBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(144, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(136, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(134, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // logTitle_panel
            // 
            this.logTitle_panel.Controls.Add(this.logTitle_label);
            this.logTitle_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logTitle_panel.Location = new System.Drawing.Point(5, 5);
            this.logTitle_panel.Name = "logTitle_panel";
            this.logTitle_panel.Size = new System.Drawing.Size(648, 30);
            this.logTitle_panel.TabIndex = 0;
            // 
            // logMessage_panel
            // 
            this.logMessage_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logMessage_panel.Controls.Add(this.log_label);
            this.logMessage_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logMessage_panel.Location = new System.Drawing.Point(5, 35);
            this.logMessage_panel.Name = "logMessage_panel";
            this.logMessage_panel.Size = new System.Drawing.Size(648, 70);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 522);
            this.Controls.Add(this.main_splitContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.main_splitContainer.Panel1.ResumeLayout(false);
            this.main_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).EndInit();
            this.main_splitContainer.ResumeLayout(false);
            this.content_splitContainer.Panel1.ResumeLayout(false);
            this.content_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.content_splitContainer)).EndInit();
            this.content_splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.image_tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.source_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_pictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.logTitle_panel.ResumeLayout(false);
            this.logTitle_panel.PerformLayout();
            this.logMessage_panel.ResumeLayout(false);
            this.logMessage_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Openfile_button;
        private System.Windows.Forms.Button Grayscale_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
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
    }
}

