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
    public class ChucVuServices : IChucVuServices
    {
        ChucVuRepos _repos = new ChucVuRepos();

        public ChucVuServices()
        {
        }

        public ChucVuServices(ChucVuRepos repos)
        {
            _repos = repos;
        }
        public List<ChucVu> GetAll()
        {
            return _repos.GetAll();
        }
        public bool Create(ChucVu chucVu)
        {
            return _repos.Create(chucVu);
        }

        public bool Delete(int Id)
        {
            return _repos.Delete(Id);
        }
        public string GetTenChucVu(int Id)
        {
            return _repos.GetTenChucVu(Id);
        }



        public bool Update(int Id, ChucVu chucVu)
        {
            return _repos.Update(Id, chucVu);
        }
        public int GetIdByTenChucVu(string tenChucVu)
        {
            return _repos.GetIdByTenChucVu(tenChucVu);
        }
    }
}
