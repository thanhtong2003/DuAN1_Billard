using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MemBerShip
    {
        public MemBerShip()
        {
            KhachHangs = new HashSet<KhachHang>();
        }

        public int IdmemBerShip { get; set; }
        public DateTime NgayGiaNhap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string LoaiTheThanhVien { get; set; } = null!;
        public double PhanTramGiam { get; set; }

        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
