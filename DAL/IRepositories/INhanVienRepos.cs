using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface INhanVienRepos
    {
        public List<NhanVien> GetAll();
        public bool Create(NhanVien nhanVien);
        public bool Update(int Id, NhanVien nhanVien);
        public bool Delete(int Id);
    }
}
