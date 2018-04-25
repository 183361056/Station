namespace Station
{
    partial class FrIDCardSave
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
            this.LaInfo = new System.Windows.Forms.Label();
            this.BtnTry = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaInfo
            // 
            this.LaInfo.AutoSize = true;
            this.LaInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LaInfo.Location = new System.Drawing.Point(198, 30);
            this.LaInfo.Name = "LaInfo";
            this.LaInfo.Size = new System.Drawing.Size(72, 16);
            this.LaInfo.TabIndex = 17;
            this.LaInfo.Text = "保存提示";
            this.LaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTry
            // 
            this.BtnTry.Location = new System.Drawing.Point(138, 74);
            this.BtnTry.Name = "BtnTry";
            this.BtnTry.Size = new System.Drawing.Size(101, 30);
            this.BtnTry.TabIndex = 18;
            this.BtnTry.Text = "重试";
            this.BtnTry.UseVisualStyleBackColor = true;
            this.BtnTry.Click += new System.EventHandler(this.BtnTry_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(267, 74);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(101, 30);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.Text = "返回";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrIDCardSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 128);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnTry);
            this.Controls.Add(this.LaInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrIDCardSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrIDCardSave";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrIDCardSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LaInfo;
        private System.Windows.Forms.Button BtnTry;
        private System.Windows.Forms.Button BtnClose;
    }
}