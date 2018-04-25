namespace Station
{
    partial class FrBuilding
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
            this.GrBuilding = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // GrBuilding
            // 
            this.GrBuilding.AllowUserToAddRows = false;
            this.GrBuilding.AllowUserToDeleteRows = false;
            this.GrBuilding.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrBuilding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrBuilding.ColumnHeadersHeight = 25;
            this.GrBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GrBuilding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GrBuilding.Location = new System.Drawing.Point(12, 12);
            this.GrBuilding.MultiSelect = false;
            this.GrBuilding.Name = "GrBuilding";
            this.GrBuilding.ReadOnly = true;
            this.GrBuilding.RowHeadersWidth = 20;
            this.GrBuilding.RowTemplate.Height = 23;
            this.GrBuilding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrBuilding.Size = new System.Drawing.Size(534, 320);
            this.GrBuilding.TabIndex = 0;
            this.GrBuilding.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrBuilding_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "buildingno";
            this.Column1.HeaderText = "楼号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "unitno";
            this.Column2.HeaderText = "单元号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(161, 355);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(100, 30);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "选择";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(289, 355);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 30);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "返回";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 397);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.GrBuilding);
            this.Name = "FrBuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择楼号单元";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrBuilding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrBuilding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnClose;
    }
}