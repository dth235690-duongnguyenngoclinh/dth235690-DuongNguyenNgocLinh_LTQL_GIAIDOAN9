using QL_DiemTruongTieuHoc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Diem.Data
{
    public class HocSinh
    {
        public int ID { get; set; } // Bắt buộc có ID làm khóa chính [cite: 107, 127]
        public string MaHocSinh { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoaiPhuHuynh { get; set; }
        public string LopHocs { get; set; }
        public int NamHocID { get; set; }
        public string GiaoViens { get; set; }
        
        public virtual ICollection<BangDiem> BangDiems { get; set; }
    }
}
