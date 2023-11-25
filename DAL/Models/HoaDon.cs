using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonCts = new HashSet<HoaDonCt>();
        }

        public int IdhoaDon { get; set; }
        public int? IdkhuyenMai { get; set; }
        public int IdkhachHang { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
        public decimal TongTien { get; set; }

        public virtual KhachHang IdkhachHangNavigation { get; set; } = null!;
        public virtual KhuyenMai? IdkhuyenMaiNavigation { get; set; }
        public virtual ICollection<HoaDonCt> HoaDonCts { get; set; }
    }
}
