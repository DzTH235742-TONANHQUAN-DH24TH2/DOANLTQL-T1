using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyCuaHangXeMayDien.Data
{
    public class NhaSanXuat
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNhaSanXuat { get; set; } = null!;
    }
}