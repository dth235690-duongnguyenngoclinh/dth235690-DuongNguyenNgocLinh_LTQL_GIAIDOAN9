using Microsoft.EntityFrameworkCore;
using QL_Diem.Data; // Để chương trình nhận diện được QLDiemDbContext
using QL_DiemTruongTieuHoc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; // Để đọc chuỗi kết nối từ App.config
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Diem.Forms
{
    public partial class fHocSinh : Form
    {
        public fHocSinh()
        {
            InitializeComponent();
            // Đăng ký các sự kiện
            this.Load += FHocSinh_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThoat.Click += BtnThoat_Click;
            dgvHocSinh.CellClick += DgvHocSinh_CellClick;
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            dgvHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // TỰ ĐỘNG KHÓA Ô ID: Người dùng không cần nhập, hệ thống tự phát sinh
            txtID.ReadOnly = true;
            txtID.BackColor = Color.LightGray; // Đổi màu để biết là ô bị khóa

            CapNhatIDTiepTheo();
            txtID.Enabled = false;
        }

        // Hàm hỗ trợ: Tự động tính ID dựa trên số dòng hiện có

        private void LoadData()
        {
            using (var db = new QLDiemDbContext())
            {
                // Lấy danh sách từ bảng HocSinhs trong Database
                dgvHocSinh.DataSource = db.HocSinhs.ToList();

                // Xóa chọn dòng mặc định và cập nhật ID hiển thị
                dgvHocSinh.ClearSelection();
                CapNhatIDTiepTheo();
            }
        }

        // 1. CHỨC NĂNG THÊM
        private void BtnThem_Click(object sender, EventArgs e)
        {
            using (var db = new QLDiemDbContext())
            {
                try
                {
                    // Tạo đối tượng mới dựa trên class HocSinh trong thư mục Data của em
                    var hs = new HocSinh
                    {
                        MaHocSinh = txtMaHS.Text,
                        HoTen = txtTenHS.Text,
                        LopHocs = txtLop.Text,
                        NgaySinh = dtNgaySinh.Value,
                        GiaoViens = txtGV.Text,
                        NamHocID = dtNamHoc.Value.Year,
                        SoDienThoaiPhuHuynh = txtSDT.Text,
                        GioiTinh = radioButton1.Checked ? "Nam" : "Nữ",
                        DiaChi = txtDiaChi.Text
                    };

                    db.HocSinhs.Add(hs); // Thêm vào danh sách
                    db.SaveChanges();    // Lưu xuống SQL Server

                    MessageBox.Show("Thêm học sinh thành công!");
                    LoadData();
                    XoaTrangForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        // 2. CHỨC NĂNG SỬA
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow != null)
            {
                using (var db = new QLDiemDbContext())
                {
                    // 1. Lấy ID của học sinh đang chọn trên bảng
                    int id = Convert.ToInt32(dgvHocSinh.CurrentRow.Cells[0].Value);

                    // 2. Tìm học sinh đó trong Database
                    var hs = db.HocSinhs.Find(id);

                    if (hs != null)
                    {
                        // 3. Cập nhật thông tin từ TextBox vào đối tượng
                        hs.MaHocSinh = txtMaHS.Text;
                        hs.HoTen = txtTenHS.Text;
                        hs.LopHocs = txtLop.Text;
                        hs.NgaySinh = dtNgaySinh.Value;
                        hs.GiaoViens = txtGV.Text;
                        hs.NamHocID = dtNamHoc.Value.Year;
                        hs.SoDienThoaiPhuHuynh = txtSDT.Text;
                        hs.GioiTinh = radioButton1.Checked ? "Nam" : "Nữ";
                        hs.DiaChi = txtDiaChi.Text;

                        // 4. Lưu thật sự xuống SQL Server
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật Database thành công!");
                        LoadData(); // Load lại để bảng cập nhật mới nhất
                    }
                }
            }
        }

        // 3. CHỨC NĂNG XÓA
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa học sinh này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dgvHocSinh.Rows.RemoveAt(dgvHocSinh.CurrentRow.Index);
                    CapNhatIDTiepTheo(); // Cập nhật lại số ID hiển thị
                }
            }
        }

        // 4. CLICK VÀO BẢNG HIỆN LÊN TEXTBOX
        private void DgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHocSinh.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value?.ToString();
                txtMaHS.Text = row.Cells[1].Value?.ToString();
                txtTenHS.Text = row.Cells[2].Value?.ToString();
                txtLop.Text = row.Cells[3].Value?.ToString();

                if (DateTime.TryParse(row.Cells[4].Value?.ToString(), out DateTime ns))
                    dtNgaySinh.Value = ns;

                txtGV.Text = row.Cells[5].Value?.ToString();
                txtSDT.Text = row.Cells[7].Value?.ToString();

                if (row.Cells[8].Value?.ToString() == "Nam")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

                txtDiaChi.Text = row.Cells[9].Value?.ToString();
            }
        }
  private void CapNhatIDTiepTheo()
        {
            // Đếm số dòng đang có trong DataGridView
            int soDong = dgvHocSinh.Rows.Count;
            // ID tiếp theo sẽ bằng số dòng + 1
            txtID.Text = (soDong + 1).ToString();
        }
        // 5. THOÁT
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XoaTrangForm()
        {
            // Không xóa ô ID vì nó tự nhảy số
            txtMaHS.Clear();
            txtTenHS.Clear();
            txtLop.Clear();
            txtGV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMaHS.Focus(); // Cho con trỏ vào ô Mã HS thay vì ID
        }
    }
}