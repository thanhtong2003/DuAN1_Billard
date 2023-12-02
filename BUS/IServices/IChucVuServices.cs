using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IChucVuServices
    {
        public List<ChucVu> GetAll();
        public bool Create(ChucVu chucVu);
        public bool Update(int Id, ChucVu chucVu);
        public bool Delete(int Id);
        public string GetTenChucVu(int Id);
        public int GetIdByTenChucVu(string tenChucVu);
    }
}
