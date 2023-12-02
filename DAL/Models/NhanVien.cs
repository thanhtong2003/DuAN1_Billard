using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NhanVien
    {
        public int IdnhanVien { get; set; }
        public int IdchucVu { get; set; }
        public string TenNhanVien { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public string SoDienThoai { get; set; } = null!;
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TrangThai { get; set; } = null!;
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ChucVu IdchucVuNavigation { get; set; } = null!;
    }
}
