namespace Station
{
    partial class FrMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MiCard = new System.Windows.Forms.ToolStripMenuItem();
            this.MiOther = new System.Windows.Forms.ToolStripMenuItem();
            this.MiBaseData = new System.Windows.Forms.ToolStripMenuItem();
            this.MiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TssLa1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLa2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiCard,
            this.MiOther,
            this.MiBaseData,
            this.MiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1399, 28);
            this.menuStrip1.TabIndex = 0;
            // 
            // MiCard
            // 
            this.MiCard.Name = "MiCard";
            this.MiCard.Size = new System.Drawing.Size(133, 24);
            this.MiCard.Text = "居民身份信息采集";
            this.MiCard.Click += new System.EventHandler(this.MiCard_Click);
            // 
            // MiOther
            // 
            this.MiOther.Name = "MiOther";
            this.MiOther.Size = new System.Drawing.Size(133, 24);
            this.MiOther.Text = "其他人群信息采集";
            // 
            // MiBaseData
            // 
            this.MiBaseData.Name = "MiBaseData";
            this.MiBaseData.Size = new System.Drawing.Size(77, 24);
            this.MiBaseData.Text = "基础数据";
            this.MiBaseData.Click += new System.EventHandler(this.MiBaseData_Click);
            // 
            // MiExit
            // 
            this.MiExit.Name = "MiExit";
            this.MiExit.Size = new System.Drawing.Size(77, 24);
            this.MiExit.Text = "系统退出";
            this.MiExit.Click += new System.EventHandler(this.MiExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLa1,
            this.TssLa2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 761);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1399, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TssLa1
            // 
            this.TssLa1.AutoSize = false;
            this.TssLa1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TssLa1.Name = "TssLa1";
            this.TssLa1.Size = new System.Drawing.Size(400, 17);
            this.TssLa1.Text = "版权所有：陕西远洋科技实业有限责任公司";
            this.TssLa1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TssLa2
            // 
            this.TssLa2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TssLa2.ForeColor = System.Drawing.Color.Red;
            this.TssLa2.Name = "TssLa2";
            this.TssLa2.Size = new System.Drawing.Size(56, 17);
            this.TssLa2.Text = "长乐方";
            this.TssLa2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 783);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社区居民信息采集系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MiCard;
        private System.Windows.Forms.ToolStripMenuItem MiOther;
        private System.Windows.Forms.ToolStripMenuItem MiBaseData;
        private System.Windows.Forms.ToolStripMenuItem MiExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TssLa1;
        private System.Windows.Forms.ToolStripStatusLabel TssLa2;
    }
}

