using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int IdkhachHang { get; set; }
        public int? IdmemBerShip { get; set; }
        public string HoVaTen { get; set; } = null!;
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual MemBerShip? IdmemBerShipNavigation { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
