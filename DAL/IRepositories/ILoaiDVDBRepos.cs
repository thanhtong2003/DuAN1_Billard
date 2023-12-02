using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ILoaiDVDBRepos
    {
        public List<LoaiDichVuDb> GetAll();
        public bool Create(LoaiDichVuDb obj);
        public bool Update(int id, LoaiDichVuDb obj);
        public bool Delete(int id);
        public string GetByName(int Id);
        public int GetIdByName(string name);
    }
}
