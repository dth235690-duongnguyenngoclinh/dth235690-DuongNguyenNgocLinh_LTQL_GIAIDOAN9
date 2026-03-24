using Microsoft.EntityFrameworkCore;
using QL_Diem.Data;
using QL_DiemTruongTieuHoc.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QL_Diem.Forms
{
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
            // Mẹo: Ẩn mật khẩu bằng dấu * ngay khi khởi tạo
            txtMatKhau.PasswordChar = '*';
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            cmbLoaiTaiKhoan.Items.Clear();
            cmbLoaiTaiKhoan.Items.Add("Admin");
            cmbLoaiTaiKhoan.Items.Add("Giáo Viên");
            cmbLoaiTaiKhoan.SelectedIndex = 0;
        }

        private void LoadData()
        {
            try
            {
                using (var db = new QLDiemDbContext())
                {
                    var data = db.TaiKhoans.Select(t => new
                    {
                        t.ID,
                        t.TenDangNhap,
                        t.MatKhau,
                        t.LoaiTaiKhoan
                    }).ToList();

                    dgvTaiKhoan.AutoGenerateColumns = false; // Giữ nguyên thiết kế bảng của em
                    dgvTaiKhoan.DataSource = null;
                    dgvTaiKhoan.DataSource = data;
                }

                // Ẩn cột mật khẩu trên lưới để an toàn
                if (dgvTaiKhoan.Columns["MatKhau"] != null)
                    dgvTaiKhoan.Columns["MatKhau"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // 1. KIỂM TRA BẮT BUỘC: Không cho phép để trống bất kỳ trường nào
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo");
                return;
            }

            using (var db = new QLDiemDbContext())
            {
                string tenMoi = txtTenDangNhap.Text.Trim();

                // 2. KIỂM TRA TRÙNG: Chặn đứng nếu tên đăng nhập đã tồn tại trong Database
                if (db.TaiKhoans.Any(x => x.TenDangNhap == tenMoi))
                {
                    MessageBox.Show("Tên đăng nhập này đã bị trùng! Vui lòng nhập tên khác.", "Thông báo");
                    txtTenDangNhap.Focus();
                    return; // Dừng lại ở đây, không chạy xuống lệnh Add bên dưới
                }

                // 3. NẾU KHÔNG TRÙNG THÌ MỚI LƯU
                var tk = new TaiKhoan
                {
                    TenDangNhap = tenMoi, // Xóa khoảng trắng thừa
                    MatKhau = txtMatKhau.Text.Trim(),
                    LoaiTaiKhoan = cmbLoaiTaiKhoan.Text
                };

                db.TaiKhoans.Add(tk);
                db.SaveChanges();
            }

            LoadData();
            btnLamMoi_Click(null, null);
            MessageBox.Show("Thêm tài khoản thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow != null)
            {
                // Kiểm tra dữ liệu trước khi sửa
                if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Không được để trống thông tin khi sửa!");
                    return;
                }

                int id = (int)dgvTaiKhoan.CurrentRow.Cells["ID"].Value;
                using (var db = new QLDiemDbContext())
                {
                    var tk = db.TaiKhoans.Find(id);
                    if (tk != null)
                    {
                        tk.TenDangNhap = txtTenDangNhap.Text.Trim();
                        tk.MatKhau = txtMatKhau.Text.Trim();
                        tk.LoaiTaiKhoan = cmbLoaiTaiKhoan.Text;
                        db.SaveChanges();
                    }
                }
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow != null)
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    int id = (int)dgvTaiKhoan.CurrentRow.Cells["ID"].Value;
                    using (var db = new QLDiemDbContext())
                    {
                        var tk = db.TaiKhoans.Find(id);
                        if (tk != null)
                        {
                            db.TaiKhoans.Remove(tk);
                            db.SaveChanges();
                        }
                    }
                    LoadData();
                    btnLamMoi_Click(null, null);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            if (cmbLoaiTaiKhoan.Items.Count > 0) cmbLoaiTaiKhoan.SelectedIndex = 0;
            txtTenDangNhap.Focus();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTaiKhoan.CurrentRow != null)
            {
                txtID.Text = dgvTaiKhoan.CurrentRow.Cells["ID"].Value?.ToString();
                txtTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells["TenDangNhap"].Value?.ToString();
                txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells["MatKhau"].Value?.ToString();
                cmbLoaiTaiKhoan.Text = dgvTaiKhoan.CurrentRow.Cells["LoaiTaiKhoan"].Value?.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            using (var db = new QLDiemDbContext())
            {
                // 1. Xóa sạch dữ liệu trong bảng TaiKhoan
                // Lưu ý: Tên bảng trong Database của em thường là 'TaiKhoans' (có chữ s)
                db.Database.ExecuteSqlRaw("DELETE FROM TaiKhoans");

                // 2. Lệnh reset ID (Identity) quay về 0
                db.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('TaiKhoans', RESEED, 0)");

                MessageBox.Show("Đã dọn dẹp và reset ID về 1 thành công!");
            }
            LoadData(); // Load lại bảng trắng tinh
        }
    }
}