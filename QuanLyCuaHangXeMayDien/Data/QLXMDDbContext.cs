using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class QLXMDDbContext : DbContext
    {
        public DbSet<LoaiXe> LoaiXes { get; set; }
        public DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public DbSet<XeMayDien> XeMayDiens { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["QLXMDConnection"]?.ConnectionString;

                if (connectionString != null)
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }
                else
                {
                    optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=QLXeMayDien; Integrated Security=True; TrustServerCertificate=True");
                }
            }
        }
    }
}