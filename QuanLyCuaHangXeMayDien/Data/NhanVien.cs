using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class NhanVien
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; } = null!;

        [StringLength(20)]
        public string? DienThoai { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; } = null!;
    }
}