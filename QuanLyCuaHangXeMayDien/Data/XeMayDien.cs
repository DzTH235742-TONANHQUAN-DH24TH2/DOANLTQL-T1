using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class XeMayDien
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TenXe { get; set; } = null!;

        public int DonGia { get; set; }

        public int SoLuong { get; set; }

        public string? HinhAnh { get; set; }

        public string? MoTa { get; set; }

        public int LoaiXeID { get; set; }

        [ForeignKey("LoaiXeID")]
        public virtual LoaiXe LoaiXe { get; set; } = null!;

        public int NhaSanXuatID { get; set; }

        [ForeignKey("NhaSanXuatID")]
        public virtual NhaSanXuat NhaSanXuat { get; set; } = null!;
    }
}
