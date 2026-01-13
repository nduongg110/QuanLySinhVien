namespace QuanLySinhVien.GUI
{
    partial class fBangDiemSV
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPhanTramLop = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numPhanTramThi = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDiemLop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDiemThi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbDiemTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbLoai = new System.Windows.Forms.TextBox();
            this.txbMaNH = new System.Windows.Forms.TextBox();
            this.txbMaSV = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 365);
            this.panel2.TabIndex = 7;
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AllowUserToDeleteRows = false;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.Location = new System.Drawing.Point(0, 0);
            this.dgvDiem.MultiSelect = false;
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.RowHeadersVisible = false;
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 30;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(788, 365);
            this.dgvDiem.TabIndex = 1;
            this.dgvDiem.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã SV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã MH";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "% trên lớp";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "% thi";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 85;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điểm trên lớp";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Điểm thi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Điểm TB";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Loại";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(60, 10);
            this.txbID.MaxLength = 255;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(50, 26);
            this.txbID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phần trăm trên lớp:";
            // 
            // numPhanTramLop
            // 
            this.numPhanTramLop.Enabled = false;
            this.numPhanTramLop.Location = new System.Drawing.Point(429, 11);
            this.numPhanTramLop.Name = "numPhanTramLop";
            this.numPhanTramLop.Size = new System.Drawing.Size(55, 26);
            this.numPhanTramLop.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phần trăm thi:";
            // 
            // numPhanTramThi
            // 
            this.numPhanTramThi.Enabled = false;
            this.numPhanTramThi.Location = new System.Drawing.Point(430, 45);
            this.numPhanTramThi.Name = "numPhanTramThi";
            this.numPhanTramThi.Size = new System.Drawing.Size(54, 26);
            this.numPhanTramThi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Điểm lớp:";
            // 
            // txbDiemLop
            // 
            this.txbDiemLop.Enabled = false;
            this.txbDiemLop.Location = new System.Drawing.Point(655, 10);
            this.txbDiemLop.MaxLength = 255;
            this.txbDiemLop.Name = "txbDiemLop";
            this.txbDiemLop.Size = new System.Drawing.Size(66, 26);
            this.txbDiemLop.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Điểm thi:";
            // 
            // txbDiemThi
            // 
            this.txbDiemThi.Enabled = false;
            this.txbDiemThi.Location = new System.Drawing.Point(655, 44);
            this.txbDiemThi.MaxLength = 255;
            this.txbDiemThi.Name = "txbDiemThi";
            this.txbDiemThi.Size = new System.Drawing.Size(66, 26);
            this.txbDiemThi.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Điểm trung bình:";
            // 
            // txbDiemTB
            // 
            this.txbDiemTB.Enabled = false;
            this.txbDiemTB.Location = new System.Drawing.Point(430, 81);
            this.txbDiemTB.MaxLength = 255;
            this.txbDiemTB.Name = "txbDiemTB";
            this.txbDiemTB.Size = new System.Drawing.Size(54, 26);
            this.txbDiemTB.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Loại:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMaSV);
            this.panel1.Controls.Add(this.txbMaNH);
            this.panel1.Controls.Add(this.txbLoai);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txbDiemTB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbDiemThi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbDiemLop);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numPhanTramThi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numPhanTramLop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 121);
            this.panel1.TabIndex = 6;
            // 
            // txbLoai
            // 
            this.txbLoai.Enabled = false;
            this.txbLoai.Location = new System.Drawing.Point(655, 81);
            this.txbLoai.MaxLength = 255;
            this.txbLoai.Name = "txbLoai";
            this.txbLoai.Size = new System.Drawing.Size(66, 26);
            this.txbLoai.TabIndex = 8;
            // 
            // txbMaNH
            // 
            this.txbMaNH.Enabled = false;
            this.txbMaNH.Location = new System.Drawing.Point(121, 81);
            this.txbMaNH.MaxLength = 255;
            this.txbMaNH.Name = "txbMaNH";
            this.txbMaNH.Size = new System.Drawing.Size(66, 26);
            this.txbMaNH.TabIndex = 2;
            // 
            // txbMaSV
            // 
            this.txbMaSV.Enabled = false;
            this.txbMaSV.Location = new System.Drawing.Point(121, 47);
            this.txbMaSV.MaxLength = 255;
            this.txbMaSV.Name = "txbMaSV";
            this.txbMaSV.Size = new System.Drawing.Size(66, 26);
            this.txbMaSV.TabIndex = 1;
            // 
            // fBangDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fBangDiemSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng điểm sinh viên";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPhanTramLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPhanTramThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDiemLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDiemThi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbDiemTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMaSV;
        private System.Windows.Forms.TextBox txbMaNH;
        private System.Windows.Forms.TextBox txbLoai;
    }
}