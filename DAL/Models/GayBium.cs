using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GayBium
    {
        public GayBium()
        {
            DichVus = new HashSet<DichVu>();
        }

        public int IdgayBiA { get; set; }
        public string TenGayBiA { get; set; } = null!;
        public string LoaiGayBiA { get; set; } = null!;
        public decimal DonGia { get; set; }
        public string TrangThai { get; set; } = null!;
        public int SoLuong { get; set; }

        public virtual ICollection<DichVu> DichVus { get; set; }
    }
}
