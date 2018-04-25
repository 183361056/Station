namespace Station
{
    partial class FrCardData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrData = new System.Windows.Forms.DataGridView();
            this.Tbidn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbfullname = new System.Windows.Forms.TextBox();
            this.BtnCard = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrData)).BeginInit();
            this.SuspendLayout();
            // 
            // GrData
            // 
            this.GrData.AllowUserToAddRows = false;
            this.GrData.AllowUserToDeleteRows = false;
            this.GrData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrData.ColumnHeadersHeight = 25;
            this.GrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GrData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column14,
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column13});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrData.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrData.Location = new System.Drawing.Point(2, 87);
            this.GrData.MultiSelect = false;
            this.GrData.Name = "GrData";
            this.GrData.ReadOnly = true;
            this.GrData.RowHeadersWidth = 20;
            this.GrData.RowTemplate.Height = 23;
            this.GrData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrData.Size = new System.Drawing.Size(1274, 668);
            this.GrData.TabIndex = 1;
            this.GrData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrData_CellDoubleClick);
            // 
            // Tbidn
            // 
            this.Tbidn.Location = new System.Drawing.Point(104, 35);
            this.Tbidn.MaxLength = 18;
            this.Tbidn.Name = "Tbidn";
            this.Tbidn.Size = new System.Drawing.Size(278, 21);
            this.Tbidn.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(14, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "身份证号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(421, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "姓名";
            // 
            // Tbfullname
            // 
            this.Tbfullname.Location = new System.Drawing.Point(467, 35);
            this.Tbfullname.MaxLength = 10;
            this.Tbfullname.Name = "Tbfullname";
            this.Tbfullname.Size = new System.Drawing.Size(141, 21);
            this.Tbfullname.TabIndex = 33;
            // 
            // BtnCard
            // 
            this.BtnCard.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCard.Location = new System.Drawing.Point(645, 28);
            this.BtnCard.Name = "BtnCard";
            this.BtnCard.Size = new System.Drawing.Size(98, 28);
            this.BtnCard.TabIndex = 34;
            this.BtnCard.Text = "查询";
            this.BtnCard.UseVisualStyleBackColor = true;
            this.BtnCard.Click += new System.EventHandler(this.BtnCard_Click);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fullname";
            this.Column3.HeaderText = "姓名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "idn";
            this.Column4.HeaderText = "身份证号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "commid";
            this.Column14.HeaderText = "小区编号";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "buildingno";
            this.Column1.HeaderText = "楼号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "unitno";
            this.Column2.HeaderText = "单元号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "roomno";
            this.Column10.HeaderText = "房号";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "floors";
            this.Column11.HeaderText = "楼层";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "rooms";
            this.Column12.HeaderText = "房间数";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "contactway";
            this.Column5.HeaderText = "联系方式";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "housetype";
            this.Column6.HeaderText = "房屋类型";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "purpose";
            this.Column7.HeaderText = "房屋用途";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "usestatus";
            this.Column8.HeaderText = "居住现状";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "workplace";
            this.Column9.HeaderText = "工作单位";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 200;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "registertime";
            this.Column13.HeaderText = "登记时间";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // FrCardData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 757);
            this.Controls.Add(this.BtnCard);
            this.Controls.Add(this.Tbfullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbidn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GrData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrCardData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "居民身份信息管理";
            this.Load += new System.EventHandler(this.FrCardData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrData;
        private System.Windows.Forms.TextBox Tbidn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbfullname;
        private System.Windows.Forms.Button BtnCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}