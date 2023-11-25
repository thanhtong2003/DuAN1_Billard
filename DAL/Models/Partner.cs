using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Partner
    {
        public Partner()
        {
            DichVus = new HashSet<DichVu>();
        }

        public int Idpartner { get; set; }
        public string TenPatrner { get; set; } = null!;
        public string LoaiPartner { get; set; } = null!;
        public decimal DonGia { get; set; }
        public string TrangThai { get; set; } = null!;

        public virtual ICollection<DichVu> DichVus { get; set; }
    }
}
