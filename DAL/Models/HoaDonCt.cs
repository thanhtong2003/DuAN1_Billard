using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDonCt
    {
        public int IdhoaDonCt { get; set; }
        public int IddichVu { get; set; }
        public int IddichVuDb { get; set; }
        public int IdhoaDon { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public TimeSpan SoGioChoi { get; set; }
        public int SoLuong { get; set; }
        public string? GhiChu { get; set; }
        public decimal TongTien { get; set; }
        public bool TrangThai { get; set; }

        public virtual DichVuDb IddichVuDbNavigation { get; set; } = null!;
        public virtual DichVu IddichVuNavigation { get; set; } = null!;
        public virtual HoaDon IdhoaDonNavigation { get; set; } = null!;
    }
}
