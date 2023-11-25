using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DichVuDb
    {
        public DichVuDb()
        {
            HoaDonCts = new HashSet<HoaDonCt>();
        }

        public int IddichVuDb { get; set; }
        public int IdloaiDichVu { get; set; }
        public string TenDichVuDb { get; set; } = null!;
        public string? MoTa { get; set; }
        public decimal DonGia { get; set; }

        public virtual LoaiDichVuDb IdloaiDichVuNavigation { get; set; } = null!;
        public virtual ICollection<HoaDonCt> HoaDonCts { get; set; }
    }
}
