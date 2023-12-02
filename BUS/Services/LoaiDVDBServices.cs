using BUS.IServices;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class LoaiDVDBServices : ILoaiDVDBServices
    {
        LoaiDVDBRepos _repos = new LoaiDVDBRepos();

        public LoaiDVDBServices()
        {
        }

        public LoaiDVDBServices(LoaiDVDBRepos repos)
        {
            _repos = repos;
        }

        public bool Create(LoaiDichVuDb obj)
        {
            return _repos.Create(obj);
        }

        public bool Delete(int id)
        {
            return (_repos.Delete(id));
        }

        public List<LoaiDichVuDb> GetAll()
        {
           return _repos.GetAll();
        }

        public string GetByName(int Id)
        {
            return _repos.GetByName(Id);
        }

        public int GetIdByName(string name)
        {
            return _repos.GetIdByName(name);
        }

        public bool Update(int id, LoaiDichVuDb obj)
        {
            return _repos.Update(id, obj);
        }
    }
}
