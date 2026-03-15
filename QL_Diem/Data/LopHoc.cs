using QL_Diem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiemTruongTieuHoc.Data
{
    public class LopHoc
    {
        public int ID { get; set; }
        public string TenLop { get; set; } // Ví dụ: 1A, 2B
        public string NamHoc { get; set; } // Ví dụ: 2025-2026
        public string GiaoVienChuNhiem { get; set; }

        // Quan hệ: 1 lớp có nhiều học sinh
        public virtual ICollection<HocSinh> HocSinhs { get; set; }
    }
}
