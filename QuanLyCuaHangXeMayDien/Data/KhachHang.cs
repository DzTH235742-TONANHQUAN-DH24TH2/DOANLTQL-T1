using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class KhachHang
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; } = null!;

        [StringLength(20)]
        public string? DienThoai { get; set; }

        public string? DiaChi { get; set; }
    }
}