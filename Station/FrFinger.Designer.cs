namespace Station
{
    partial class FrFinger
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.LaRightFp = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Pbrightfp = new System.Windows.Forms.PictureBox();
            this.LaLeftFp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pbleftfp = new System.Windows.Forms.PictureBox();
            this.BtnFPRight = new System.Windows.Forms.Button();
            this.BtnFPLeft = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.LaInfo = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbrightfp)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbleftfp)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 690);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "toolStripStatus";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatus.Text = "状态提示";
            // 
            // LaRightFp
            // 
            this.LaRightFp.AutoSize = true;
            this.LaRightFp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LaRightFp.Location = new System.Drawing.Point(744, 522);
            this.LaRightFp.Name = "LaRightFp";
            this.LaRightFp.Size = new System.Drawing.Size(88, 16);
            this.LaRightFp.TabIndex = 20;
            this.LaRightFp.Text = "指纹质量：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Pbrightfp);
            this.groupBox3.Location = new System.Drawing.Point(616, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 450);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "右手拇指";
            // 
            // Pbrightfp
            // 
            this.Pbrightfp.Location = new System.Drawing.Point(20, 20);
            this.Pbrightfp.Name = "Pbrightfp";
            this.Pbrightfp.Size = new System.Drawing.Size(300, 420);
            this.Pbrightfp.TabIndex = 1;
            this.Pbrightfp.TabStop = false;
            // 
            // LaLeftFp
            // 
            this.LaLeftFp.AutoSize = true;
            this.LaLeftFp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LaLeftFp.Location = new System.Drawing.Point(190, 533);
            this.LaLeftFp.Name = "LaLeftFp";
            this.LaLeftFp.Size = new System.Drawing.Size(88, 16);
            this.LaLeftFp.TabIndex = 19;
            this.LaLeftFp.Text = "指纹质量：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pbleftfp);
            this.groupBox2.Location = new System.Drawing.Point(84, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 450);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "左手拇指";
            // 
            // Pbleftfp
            // 
            this.Pbleftfp.Location = new System.Drawing.Point(20, 20);
            this.Pbleftfp.Name = "Pbleftfp";
            this.Pbleftfp.Size = new System.Drawing.Size(300, 420);
            this.Pbleftfp.TabIndex = 1;
            this.Pbleftfp.TabStop = false;
            // 
            // BtnFPRight
            // 
            this.BtnFPRight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.BtnFPRight.Location = new System.Drawing.Point(648, 623);
            this.BtnFPRight.Name = "BtnFPRight";
            this.BtnFPRight.Size = new System.Drawing.Size(130, 40);
            this.BtnFPRight.TabIndex = 22;
            this.BtnFPRight.Text = "右手拇指";
            this.BtnFPRight.UseVisualStyleBackColor = true;
            this.BtnFPRight.Click += new System.EventHandler(this.BtnFPRight_Click);
            // 
            // BtnFPLeft
            // 
            this.BtnFPLeft.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.BtnFPLeft.Location = new System.Drawing.Point(512, 623);
            this.BtnFPLeft.Name = "BtnFPLeft";
            this.BtnFPLeft.Size = new System.Drawing.Size(130, 40);
            this.BtnFPLeft.TabIndex = 21;
            this.BtnFPLeft.Text = "左手拇指";
            this.BtnFPLeft.UseVisualStyleBackColor = true;
            this.BtnFPLeft.Click += new System.EventHandler(this.BtnFPLeft_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(784, 623);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 40);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnNext.Location = new System.Drawing.Point(920, 623);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(130, 40);
            this.BtnNext.TabIndex = 23;
            this.BtnNext.Text = "下一步";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LaInfo
            // 
            this.LaInfo.AutoSize = true;
            this.LaInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LaInfo.Location = new System.Drawing.Point(190, 623);
            this.LaInfo.Name = "LaInfo";
            this.LaInfo.Size = new System.Drawing.Size(72, 16);
            this.LaInfo.TabIndex = 25;
            this.LaInfo.Text = "保存提示";
            this.LaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrFinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 712);
            this.ControlBox = false;
            this.Controls.Add(this.LaInfo);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnFPRight);
            this.Controls.Add(this.BtnFPLeft);
            this.Controls.Add(this.LaRightFp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LaLeftFp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip);
            this.Name = "FrFinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "指纹采集";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrFinger_FormClosed);
            this.Load += new System.EventHandler(this.FrFinger_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbrightfp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbleftfp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.Label LaRightFp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox Pbrightfp;
        private System.Windows.Forms.Label LaLeftFp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Pbleftfp;
        private System.Windows.Forms.Button BtnFPRight;
        private System.Windows.Forms.Button BtnFPLeft;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label LaInfo;
    }
}