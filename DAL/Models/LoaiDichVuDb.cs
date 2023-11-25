using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LoaiDichVuDb
    {
        public LoaiDichVuDb()
        {
            DichVuDbs = new HashSet<DichVuDb>();
        }

        public int IdloaiDichVuDb { get; set; }
        public string TenLoaiDichVuDb { get; set; } = null!;
        public string? MoTa { get; set; }

        public virtual ICollection<DichVuDb> DichVuDbs { get; set; }
    }
}
