namespace Station
{
    partial class FrCardEdit
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
            this.Tbunitno = new System.Windows.Forms.TextBox();
            this.Tbbuildingno = new System.Windows.Forms.TextBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Cbhousetype = new System.Windows.Forms.ComboBox();
            this.Tbcontactway = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Nufloor = new System.Windows.Forms.NumericUpDown();
            this.Cbroomstatus = new System.Windows.Forms.ComboBox();
            this.Cbroompurpose = new System.Windows.Forms.ComboBox();
            this.Tbworkplace = new System.Windows.Forms.TextBox();
            this.Nurooms = new System.Windows.Forms.NumericUpDown();
            this.Tbroomno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Nufloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nurooms)).BeginInit();
            this.SuspendLayout();
            // 
            // LaInfo
            // 
            this.LaInfo.AutoSize = true;
            this.LaInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LaInfo.ForeColor = System.Drawing.Color.Red;
            this.LaInfo.Location = new System.Drawing.Point(278, 446);
            this.LaInfo.Name = "LaInfo";
            this.LaInfo.Size = new System.Drawing.Size(72, 16);
            this.LaInfo.TabIndex = 56;
            this.LaInfo.Text = "保存提示";
            this.LaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tbunitno
            // 
            this.Tbunitno.BackColor = System.Drawing.Color.White;
            this.Tbunitno.Location = new System.Drawing.Point(336, 71);
            this.Tbunitno.Name = "Tbunitno";
            this.Tbunitno.ReadOnly = true;
            this.Tbunitno.Size = new System.Drawing.Size(100, 21);
            this.Tbunitno.TabIndex = 55;
            // 
            // Tbbuildingno
            // 
            this.Tbbuildingno.BackColor = System.Drawing.Color.White;
            this.Tbbuildingno.Location = new System.Drawing.Point(234, 71);
            this.Tbbuildingno.Name = "Tbbuildingno";
            this.Tbbuildingno.ReadOnly = true;
            this.Tbbuildingno.Size = new System.Drawing.Size(100, 21);
            this.Tbbuildingno.TabIndex = 54;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(438, 69);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(39, 23);
            this.BtnSelect.TabIndex = 53;
            this.BtnSelect.Text = "...";
            this.BtnSelect.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(133, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "房屋类型";
            // 
            // Cbhousetype
            // 
            this.Cbhousetype.BackColor = System.Drawing.Color.White;
            this.Cbhousetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbhousetype.FormattingEnabled = true;
            this.Cbhousetype.Location = new System.Drawing.Point(234, 273);
            this.Cbhousetype.Name = "Cbhousetype";
            this.Cbhousetype.Size = new System.Drawing.Size(278, 20);
            this.Cbhousetype.TabIndex = 51;
            // 
            // Tbcontactway
            // 
            this.Tbcontactway.Location = new System.Drawing.Point(234, 390);
            this.Tbcontactway.Name = "Tbcontactway";
            this.Tbcontactway.Size = new System.Drawing.Size(278, 21);
            this.Tbcontactway.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(133, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "联系方式";
            // 
            // Nufloor
            // 
            this.Nufloor.Location = new System.Drawing.Point(234, 148);
            this.Nufloor.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Nufloor.Name = "Nufloor";
            this.Nufloor.Size = new System.Drawing.Size(100, 21);
            this.Nufloor.TabIndex = 48;
            this.Nufloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cbroomstatus
            // 
            this.Cbroomstatus.BackColor = System.Drawing.Color.White;
            this.Cbroomstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbroomstatus.FormattingEnabled = true;
            this.Cbroomstatus.Location = new System.Drawing.Point(234, 346);
            this.Cbroomstatus.Name = "Cbroomstatus";
            this.Cbroomstatus.Size = new System.Drawing.Size(278, 20);
            this.Cbroomstatus.TabIndex = 47;
            // 
            // Cbroompurpose
            // 
            this.Cbroompurpose.BackColor = System.Drawing.Color.White;
            this.Cbroompurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbroompurpose.FormattingEnabled = true;
            this.Cbroompurpose.Location = new System.Drawing.Point(234, 311);
            this.Cbroompurpose.Name = "Cbroompurpose";
            this.Cbroompurpose.Size = new System.Drawing.Size(278, 20);
            this.Cbroompurpose.TabIndex = 46;
            // 
            // Tbworkplace
            // 
            this.Tbworkplace.Location = new System.Drawing.Point(234, 231);
            this.Tbworkplace.MaxLength = 50;
            this.Tbworkplace.Name = "Tbworkplace";
            this.Tbworkplace.Size = new System.Drawing.Size(278, 21);
            this.Tbworkplace.TabIndex = 45;
            // 
            // Nurooms
            // 
            this.Nurooms.Location = new System.Drawing.Point(234, 187);
            this.Nurooms.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Nurooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nurooms.Name = "Nurooms";
            this.Nurooms.Size = new System.Drawing.Size(100, 21);
            this.Nurooms.TabIndex = 44;
            this.Nurooms.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Tbroomno
            // 
            this.Tbroomno.Location = new System.Drawing.Point(234, 109);
            this.Tbroomno.MaxLength = 10;
            this.Tbroomno.Name = "Tbroomno";
            this.Tbroomno.Size = new System.Drawing.Size(100, 21);
            this.Tbroomno.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(149, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "房间数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(133, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "房屋用途";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(133, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "居住现状";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(133, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "工作单位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(165, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "房号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(165, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "楼层";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(117, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "楼(单元)号";
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnNext.Location = new System.Drawing.Point(336, 481);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(130, 40);
            this.BtnNext.TabIndex = 57;
            this.BtnNext.Text = "保存";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(179, 481);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 40);
            this.BtnCancel.TabIndex = 58;
            this.BtnCancel.Text = "返回";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.ForeColor = System.Drawing.Color.Red;
            this.label_name.Location = new System.Drawing.Point(278, 34);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(42, 16);
            this.label_name.TabIndex = 59;
            this.label_name.Text = "姓名";
            // 
            // FrCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 533);
            this.ControlBox = false;
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.LaInfo);
            this.Controls.Add(this.Tbunitno);
            this.Controls.Add(this.Tbbuildingno);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cbhousetype);
            this.Controls.Add(this.Tbcontactway);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Nufloor);
            this.Controls.Add(this.Cbroomstatus);
            this.Controls.Add(this.Cbroompurpose);
            this.Controls.Add(this.Tbworkplace);
            this.Controls.Add(this.Nurooms);
            this.Controls.Add(this.Tbroomno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrCardEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改一标三实信息";
            this.Load += new System.EventHandler(this.FrCardEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nufloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nurooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LaInfo;
        private System.Windows.Forms.TextBox Tbunitno;
        private System.Windows.Forms.TextBox Tbbuildingno;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cbhousetype;
        private System.Windows.Forms.TextBox Tbcontactway;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Nufloor;
        private System.Windows.Forms.ComboBox Cbroomstatus;
        private System.Windows.Forms.ComboBox Cbroompurpose;
        private System.Windows.Forms.TextBox Tbworkplace;
        private System.Windows.Forms.NumericUpDown Nurooms;
        private System.Windows.Forms.TextBox Tbroomno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label_name;
    }
}