namespace QL_Diem.Forms
{
    partial class fHocSinh
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
            panel1 = new Panel();
            dgvHocSinh = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            label10 = new Label();
            txtSDT = new TextBox();
            label9 = new Label();
            dtNamHoc = new DateTimePicker();
            label8 = new Label();
            txtGV = new TextBox();
            label7 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            dtNgaySinh = new DateTimePicker();
            label5 = new Label();
            txtLop = new TextBox();
            label4 = new Label();
            txtTenHS = new TextBox();
            label3 = new Label();
            txtMaHS = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvHocSinh);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 441);
            panel1.TabIndex = 0;
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.AllowUserToDeleteRows = false;
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column10, Column9, Column6, Column7, Column8 });
            dgvHocSinh.Dock = DockStyle.Fill;
            dgvHocSinh.Location = new Point(0, 0);
            dgvHocSinh.MultiSelect = false;
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.ReadOnly = true;
            dgvHocSinh.RowHeadersVisible = false;
            dgvHocSinh.RowHeadersWidth = 51;
            dgvHocSinh.RowTemplate.Height = 30;
            dgvHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocSinh.Size = new Size(1082, 441);
            dgvHocSinh.TabIndex = 2;
            dgvHocSinh.TabStop = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã học sinh";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên học sinh";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Lớp";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 80;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ngày sinh";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 110;
            // 
            // Column10
            // 
            Column10.HeaderText = "Giáo viên";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 200;
            // 
            // Column9
            // 
            Column9.HeaderText = "Năm học";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 110;
            // 
            // Column6
            // 
            Column6.HeaderText = "SĐT phụ huynh";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Giới tính";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 90;
            // 
            // Column8
            // 
            Column8.HeaderText = "Địa chỉ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 400;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dtNamHoc);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtGV);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dtNgaySinh);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtLop);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTenHS);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtMaHS);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 140);
            panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(920, 93);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(74, 32);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(839, 93);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 32);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(758, 93);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 32);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(677, 93);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 32);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
           
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(80, 95);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(509, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 99);
            label10.Name = "label10";
            label10.Size = new Size(63, 19);
            label10.TabIndex = 19;
            label10.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(921, 53);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(147, 27);
            txtSDT.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(806, 57);
            label9.Name = "label9";
            label9.Size = new Size(116, 19);
            label9.TabIndex = 17;
            label9.Text = "SĐT phụ huynh:";
            // 
            // dtNamHoc
            // 
            dtNamHoc.Format = DateTimePickerFormat.Short;
            dtNamHoc.Location = new Point(673, 53);
            dtNamHoc.Name = "dtNamHoc";
            dtNamHoc.Size = new Size(126, 27);
            dtNamHoc.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(593, 57);
            label8.Name = "label8";
            label8.Size = new Size(75, 19);
            label8.TabIndex = 15;
            label8.Text = "Năm học:";
            // 
            // txtGV
            // 
            txtGV.Location = new Point(299, 53);
            txtGV.Name = "txtGV";
            txtGV.Size = new Size(284, 27);
            txtGV.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 57);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 13;
            label7.Text = "Giáo viên:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(160, 55);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 23);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(88, 55);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 23);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 57);
            label6.Name = "label6";
            label6.Size = new Size(75, 19);
            label6.TabIndex = 10;
            label6.Text = "Giới tính:";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Format = DateTimePickerFormat.Short;
            dtNgaySinh.Location = new Point(758, 16);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(126, 27);
            dtNgaySinh.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(673, 20);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 8;
            label5.Text = "Ngày sinh:";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(947, 16);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(94, 27);
            txtLop.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(901, 20);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 6;
            label4.Text = "Lớp:";
            // 
            // txtTenHS
            // 
            txtTenHS.Location = new Point(363, 16);
            txtTenHS.Name = "txtTenHS";
            txtTenHS.Size = new Size(302, 27);
            txtTenHS.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 20);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 4;
            label3.Text = "Tên HS:";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(180, 16);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(105, 27);
            txtMaHS.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 20);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 2;
            label2.Text = "Mã HS:";
            // 
            // txtID
            // 
            txtID.Location = new Point(51, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(56, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // fHocSinh
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 588);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fHocSinh";
            Text = "HocSinh";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtTenHS;
        private Label label3;
        private TextBox txtMaHS;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox txtLop;
        private Label label4;
        private DateTimePicker dtNgaySinh;
        private Label label5;
        private Label label8;
        private TextBox txtGV;
        private Label label7;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private TextBox txtSDT;
        private Label label9;
        private DateTimePicker dtNamHoc;
        private TextBox txtDiaChi;
        private Label label10;
        private DataGridView dgvHocSinh;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}