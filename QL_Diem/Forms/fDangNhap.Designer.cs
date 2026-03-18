namespace QL_Diem.Forms
{
    partial class fDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 26);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 45);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 117);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(39, 67);
            txtTenDangNhap.MaxLength = 255;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(276, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(39, 139);
            txtMatKhau.MaxLength = 255;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(276, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(118, 182);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(119, 41);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // fDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 250);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
    }
}