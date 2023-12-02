using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IKhuyenMaiServices
    {
        public List<KhuyenMai> GetAll();
        public bool Create(KhuyenMai obj);
        public bool Update(int id, KhuyenMai obj);
        public bool Delete(int id);
        public string GetTenKhuyenMai(int Id);
        public int GetIdByTenKhuyenMai(string tenKhuyenMai);
    }
}
