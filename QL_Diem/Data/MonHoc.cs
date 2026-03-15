using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiemTruongTieuHoc.Data
{
    public class MonHoc
    {
        public int ID { get; set; }
        public string Mamon { get; set; }
        public string TenMon { get; set; }
        public virtual ICollection<BangDiem> BangDiems { get; set; }
    }
}
