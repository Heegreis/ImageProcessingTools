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
            this.source_pictureBox = new System.Windows.Forms.PictureBox();
            this.Openfile_button = new System.Windows.Forms.Button();
            this.result_pictureBox = new System.Windows.Forms.PictureBox();
            this.grayscale_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.content_splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.source_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).BeginInit();
            this.main_splitContainer.Panel1.SuspendLayout();
            this.main_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.content_splitContainer)).BeginInit();
            this.content_splitContainer.Panel1.SuspendLayout();
            this.content_splitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // source_pictureBox
            // 
            this.source_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.source_pictureBox.Location = new System.Drawing.Point(4, 4);
            this.source_pictureBox.Name = "source_pictureBox";
            this.source_pictureBox.Size = new System.Drawing.Size(317, 183);
            this.source_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.source_pictureBox.TabIndex = 1;
            this.source_pictureBox.TabStop = false;
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
            // result_pictureBox
            // 
            this.result_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_pictureBox.Location = new System.Drawing.Point(328, 4);
            this.result_pictureBox.Name = "result_pictureBox";
            this.result_pictureBox.Size = new System.Drawing.Size(318, 183);
            this.result_pictureBox.TabIndex = 3;
            this.result_pictureBox.TabStop = false;
            // 
            // grayscale_button
            // 
            this.grayscale_button.Location = new System.Drawing.Point(84, 3);
            this.grayscale_button.Name = "grayscale_button";
            this.grayscale_button.Size = new System.Drawing.Size(75, 23);
            this.grayscale_button.TabIndex = 4;
            this.grayscale_button.Text = "灰階化";
            this.grayscale_button.UseVisualStyleBackColor = true;
            this.grayscale_button.Click += new System.EventHandler(this.grayscale_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Openfile_button);
            this.panel1.Controls.Add(this.grayscale_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 5;
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
            this.main_splitContainer.Size = new System.Drawing.Size(800, 420);
            this.main_splitContainer.SplitterDistance = 652;
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
            this.content_splitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.content_splitContainer.Size = new System.Drawing.Size(652, 420);
            this.content_splitContainer.SplitterDistance = 321;
            this.content_splitContainer.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.source_pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.result_pictureBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 319);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_splitContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.source_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.main_splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).EndInit();
            this.main_splitContainer.ResumeLayout(false);
            this.content_splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.content_splitContainer)).EndInit();
            this.content_splitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox source_pictureBox;
        private System.Windows.Forms.Button Openfile_button;
        private System.Windows.Forms.PictureBox result_pictureBox;
        private System.Windows.Forms.Button grayscale_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer main_splitContainer;
        private System.Windows.Forms.SplitContainer content_splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

