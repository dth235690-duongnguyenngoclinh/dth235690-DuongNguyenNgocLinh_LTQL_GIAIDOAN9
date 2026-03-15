using QL_Diem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiemTruongTieuHoc.Data
{
    public class BangDiem
    {
        public int ID { get; set; }
        // Liên kết tới học sinh và môn học
        public int HocSinhID { get; set; }
        public virtual HocSinh HocSinh { get; set; }
        public int MonHocID { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        // Dữ liệu điểm số
        public double? DiemGiuaKy { get; set; }
        public double? DiemCuoiKy { get; set; }
        public string HocKy { get; set; } // "Học kỳ 1" hoặc "Học kỳ 2"
        public string NhanXet { get; set; } // Giáo viên ghi chú về học sinh
        public string DanhGia { get; set; } // Hoàn thành tốt, Hoàn thành, Chưa hoàn thành
    }
}
