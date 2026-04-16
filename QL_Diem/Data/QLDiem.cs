using QL_Diem.Data;
using System;

namespace QL_DiemTruongTieuHoc.Data
{
    public class QLDiem
    {
        public int ID { get; set; }

        // Liên kết dữ liệu (Foreign Keys)
        public int HocSinhID { get; set; }
        public virtual HocSinh HocSinh { get; set; }
        public int MonHocID { get; set; }
        public virtual MonHoc MonHoc { get; set; }

        // Điểm kiểm tra thường xuyên
        public double? KTThuongXuyen1 { get; set; }
        public double? KTThuongXuyen2 { get; set; }
        public double? KTThuongXuyen3 { get; set; }

        // Điểm giữa kỳ và cuối kỳ
        public double? DiemGiuaKy { get; set; }
        public double? DiemCuoiKy { get; set; }

        // Thông tin học kỳ, năm học
        public string HocKy { get; set; }   // "Học kỳ 1", "Học kỳ 2"
        public string NamHoc { get; set; } // Ví dụ: "2025-2026"

        // Nhận xét & Đánh giá
        public string NhanXet { get; set; }
        public string DanhGia { get; set; } // Hoàn thành tốt, Hoàn thành, Chưa hoàn thành

        public DateTime NgayCapNhat { get; set; }
        public bool IsLock { get; set; }    // Khóa điểm sau khi phê duyệt
    }
}
