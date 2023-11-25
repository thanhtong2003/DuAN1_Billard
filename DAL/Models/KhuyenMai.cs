using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int IdkhuyenMai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string TenKhuyenMai { get; set; } = null!;
        public double MucGiam { get; set; }
        public string TrangThai { get; set; } = null!;
        public int SoLuong { get; set; }
        public string GhiChu { get; set; } = null!;

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
