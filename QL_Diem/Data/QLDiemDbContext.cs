using Microsoft.EntityFrameworkCore;
using QL_Diem.Data;
using System.Configuration;

namespace QL_DiemTruongTieuHoc.Data
{
    public class QLDiemDbContext : DbContext
    {
        public DbSet<HocSinh> HocSinhs { get; set; } // Khai báo bảng HocSinh [cite: 232]
        public DbSet<Lop> LopHocs { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<BangDiem> BangDiems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {// Lấy chuỗi kết nối từ file App.config [cite: 236, 238]
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLDiemConnection"].ConnectionString);
        }
    }
}