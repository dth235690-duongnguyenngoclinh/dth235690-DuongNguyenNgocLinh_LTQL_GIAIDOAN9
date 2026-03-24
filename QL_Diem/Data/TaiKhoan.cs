using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Diem.Data
{
    public class TaiKhoan
    {
        public int ID { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string LoaiTaiKhoan { get; set; } // Ví dụ: Admin, GiaoVien
    }
}
