using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class HoaDon
    {
        [Key]
        public int ID { get; set; }

        public DateTime NgayLap { get; set; } = DateTime.Now;

        public int NhanVienID { get; set; }

        [ForeignKey("NhanVienID")]
        public virtual NhanVien NhanVien { get; set; } = null!;

        public int KhachHangID { get; set; }

        [ForeignKey("KhachHangID")]
        public virtual KhachHang KhachHang { get; set; } = null!;
    }
}