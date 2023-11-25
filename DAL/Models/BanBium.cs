using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BanBium
    {
        public BanBium()
        {
            DichVus = new HashSet<DichVu>();
        }

        public int IdbanBiA { get; set; }
        public string TenBanBiA { get; set; } = null!;
        public string LoaiBanBiA { get; set; } = null!;
        public string CapBanBiA { get; set; } = null!;
        public bool TrangThai { get; set; }
        public decimal DonGia { get; set; }

        public virtual ICollection<DichVu> DichVus { get; set; }
    }
}
