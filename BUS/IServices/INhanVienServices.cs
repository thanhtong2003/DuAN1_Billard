using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface INhanVienServices
    {
        public List<NhanVien> GetAll();
        public bool Create(NhanVien nhanVien);
        public bool Update(int Id, NhanVien nhanVien);
        public bool Delete(int Id);
    }
}
