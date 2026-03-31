namespace QL_Diem.Forms
{
    partial class fDoiMatKhau
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
            btnCapNhat = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(102, 147);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(119, 41);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.TabStop = false;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(23, 104);
            txtMatKhau.MaxLength = 255;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(276, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(23, 32);
            txtTenDangNhap.MaxLength = 255;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(276, 27);
            txtTenDangNhap.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 82);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 10);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu cũ:";
            // 
            // fDoiMatKhau
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 201);
            Controls.Add(btnCapNhat);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fDoiMatKhau";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fDoiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCapNhat;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
    }
}