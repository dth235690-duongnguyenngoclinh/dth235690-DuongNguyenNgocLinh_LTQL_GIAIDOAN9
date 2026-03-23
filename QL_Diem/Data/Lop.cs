
using QL_Diem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiemTruongTieuHoc.Data
{
    public class Lop
    {
        public int ID { get; set; }
        public string MaLop { get; set; } // Ví dụ: LOP001
        public string TenLop { get; set; } // Ví dụ: 1A
        public int KhoiLop { get; set; } // Ví dụ: 1, 2, 3... (Rất quan trọng ở Tiểu học)
        public int SoLuong { get; set; } // Sĩ số dự kiến
        public string NamHoc { get; set; } // Ví dụ: 2025-2026
        public string GiaoVienChuNhiem { get; set; }
        public string PhongHoc { get; set; } // Ví dụ: P.101
        public bool DaKetThuc { get; set; } // Quản lý trạng thái lớp học

        // Quan hệ: 1 lớp có nhiều học sinh
        public virtual ICollection<HocSinh> HocSinhs { get; set; }
    }
}
