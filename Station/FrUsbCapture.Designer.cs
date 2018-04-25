namespace Station
{
    partial class FrUsbCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtCapture = new System.Windows.Forms.Button();
            this.imageFace = new System.Windows.Forms.PictureBox();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStriptype = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.captureImageBox = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageFace)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCapture
            // 
            this.BtCapture.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.BtCapture.Location = new System.Drawing.Point(654, 623);
            this.BtCapture.Name = "BtCapture";
            this.BtCapture.Size = new System.Drawing.Size(130, 40);
            this.BtCapture.TabIndex = 3;
            this.BtCapture.Text = "抓拍";
            this.BtCapture.UseVisualStyleBackColor = true;
            this.BtCapture.Click += new System.EventHandler(this.BtCapture_Click);
            // 
            // imageFace
            // 
            this.imageFace.Location = new System.Drawing.Point(790, 81);
            this.imageFace.Name = "imageFace";
            this.imageFace.Size = new System.Drawing.Size(201, 254);
            this.imageFace.TabIndex = 4;
            this.imageFace.TabStop = false;
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatus.Text = "状态提示";
            // 
            // toolStriptype
            // 
            this.toolStriptype.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStriptype.Name = "toolStriptype";
            this.toolStriptype.Size = new System.Drawing.Size(88, 17);
            this.toolStriptype.Text = "设备类型：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriptype,
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 690);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // captureImageBox
            // 
            this.captureImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.captureImageBox.Location = new System.Drawing.Point(12, 12);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(692, 587);
            this.captureImageBox.TabIndex = 12;
            this.captureImageBox.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(790, 623);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 40);
            this.BtnCancel.TabIndex = 26;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnNext.Location = new System.Drawing.Point(926, 623);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(130, 40);
            this.BtnNext.TabIndex = 25;
            this.BtnNext.Text = "完成";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // FrUsbCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 712);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.captureImageBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.imageFace);
            this.Controls.Add(this.BtCapture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrUsbCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人脸抓拍";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrUsbCapture_FormClosed);
            this.Load += new System.EventHandler(this.FrUsbCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageFace)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtCapture;
        private System.Windows.Forms.PictureBox imageFace;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStriptype;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox captureImageBox;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnNext;
    }
}