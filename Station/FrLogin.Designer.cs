namespace Station
{
    partial class FrLogin
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxUserId = new System.Windows.Forms.TextBox();
            this.TxUserPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(325, 258);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(102, 31);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(149, 258);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(102, 31);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxUserId
            // 
            this.TxUserId.Location = new System.Drawing.Point(206, 100);
            this.TxUserId.Name = "TxUserId";
            this.TxUserId.Size = new System.Drawing.Size(185, 21);
            this.TxUserId.TabIndex = 2;
            this.TxUserId.Text = "610102001";
            // 
            // TxUserPwd
            // 
            this.TxUserPwd.Location = new System.Drawing.Point(206, 146);
            this.TxUserPwd.Name = "TxUserPwd";
            this.TxUserPwd.PasswordChar = '#';
            this.TxUserPwd.Size = new System.Drawing.Size(185, 21);
            this.TxUserPwd.TabIndex = 3;
            this.TxUserPwd.UseSystemPasswordChar = true;
            // 
            // FrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 323);
            this.ControlBox = false;
            this.Controls.Add(this.TxUserPwd);
            this.Controls.Add(this.TxUserId);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.Name = "FrLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxUserId;
        private System.Windows.Forms.TextBox TxUserPwd;
    }
}