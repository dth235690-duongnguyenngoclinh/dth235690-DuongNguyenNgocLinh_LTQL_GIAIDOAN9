using QL_DiemTruongTieuHoc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Diem.Forms
{
    public partial class fLop : Form
    {
        public fLop()
        {
            InitializeComponent();
        }

        private void fLop_Load(object sender, EventArgs e)
        {

            LoadData();
        }


        // 2. Tải dữ liệu lớp học lên bảng
        private void LoadData()
        {
            try
            {
                using (var db = new QLDiemDbContext())
                {
                    var data = db.LopHocs.Select(l => new
                    {
                        l.ID,
                        l.MaLop,
                        l.TenLop,
                        l.GiaoVienChuNhiem,
                        l.SoLuong,
                        l.NamHoc // Hiển thị thêm cột năm học để kiểm tra
                    }).ToList();

                    dgvLop.DataSource = null;
                    dgvLop.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp và Tên lớp!");
                return;
            }

            try
            {
                using (var db = new QLDiemDbContext())
                {
                    if (db.LopHocs.Any(x => x.MaLop == txtMaLop.Text.Trim()))
                    {
                        MessageBox.Show("Mã lớp này đã tồn tại!");
                        return;
                    }

                    var lop = new Lop
                    {
                        MaLop = txtMaLop.Text.Trim(),
                        TenLop = txtTenLop.Text.Trim(),
                        GiaoVienChuNhiem = cmbGVCN.Text,
                        SoLuong = (int)numSoLuong.Value,
                        // QUAN TRỌNG: Thêm dòng này để không bị lỗi SqlException NamHoc
                        NamHoc = dtpkNamHoc.Value.Year.ToString()
                    };

                    db.LopHocs.Add(lop);
                    db.SaveChanges();
                }
                LoadData();
                btnLamMoi_Click(null, null);
                MessageBox.Show("Thêm lớp thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            numSoLuong.Value = 0;
            txtMaLop.Focus();
        }
        // 4. Sự kiện click bảng đổ dữ liệu lên control
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLop.CurrentRow != null)
            {
                var r = dgvLop.CurrentRow;
                txtID.Text = r.Cells["ID"].Value.ToString();
                txtMaLop.Text = r.Cells["MaLop"].Value.ToString();
                txtTenLop.Text = r.Cells["TenLop"].Value.ToString();
                cmbGVCN.Text = r.Cells["GiaoVienChuNhiem"].Value?.ToString();
                numSoLuong.Value = Convert.ToDecimal(r.Cells["SoLuong"].Value);
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            int id = (int)dgvLop.CurrentRow.Cells["ID"].Value;
            using (var db = new QLDiemDbContext())
            {
                var lop = db.LopHocs.Find(id);
                if (lop != null)
                {
                    lop.MaLop = txtMaLop.Text.Trim();
                    lop.TenLop = txtTenLop.Text.Trim();
                    lop.GiaoVienChuNhiem = cmbGVCN.Text;
                    lop.SoLuong = (int)numSoLuong.Value;
                    lop.NamHoc = "2025-2026"; // Đảm bảo không bị null khi sửa

                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            var confirm = MessageBox.Show("Xóa lớp này sẽ ảnh hưởng đến dữ liệu học sinh. Bạn chắc chứ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dgvLop.CurrentRow.Cells["ID"].Value;
                    using (var db = new QLDiemDbContext())
                    {
                        var lop = db.LopHocs.Find(id);
                        if (lop != null)
                        {
                            db.LopHocs.Remove(lop);
                            db.SaveChanges();
                            LoadData();
                            btnLamMoi_Click(null, null);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa lớp đang có học sinh!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

