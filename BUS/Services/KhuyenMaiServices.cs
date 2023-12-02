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
    public class KhuyenMaiServices : IKhuyenMaiServices
    {
        KhuyenMaiRepos _repos = new KhuyenMaiRepos();

        public KhuyenMaiServices()
        {
        }

        public KhuyenMaiServices(KhuyenMaiRepos repos)
        {
            _repos = repos;
        }

        public List<KhuyenMai> GetAll()
        {
            return _repos.GetAll();
        }
        public bool Create(KhuyenMai obj)
        {
            return _repos.Create(obj);
        }

        public bool Delete(int id)
        {
           return _repos.Delete(id);
        }

        

        public int GetIdByTenKhuyenMai(string tenKhuyenMai)
        {
            return _repos.GetIdByTenKhuyenMai(tenKhuyenMai);
        }

        public string GetTenKhuyenMai(int Id)
        {
            return _repos.GetTenKhuyenMai(Id);
        }

        public bool Update(int id, KhuyenMai obj)
        {
            return _repos.Update(id, obj);
        }
    }
}
