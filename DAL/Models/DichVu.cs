using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DichVu
    {
        public DichVu()
        {
            HoaDonCts = new HashSet<HoaDonCt>();
        }

        public int IddichVu { get; set; }
        public int? IdbanBiA { get; set; }
        public int? Idpartner { get; set; }
        public int? IdgayBiA { get; set; }
        public decimal DonGia { get; set; }

        public virtual BanBium? IdbanBiANavigation { get; set; }
        public virtual GayBium? IdgayBiANavigation { get; set; }
        public virtual Partner? IdpartnerNavigation { get; set; }
        public virtual ICollection<HoaDonCt> HoaDonCts { get; set; }
    }
}
