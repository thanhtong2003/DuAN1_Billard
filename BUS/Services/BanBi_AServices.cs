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
    public class BanBi_AServices
    {
        BanBi_aRepos _repos = new BanBi_aRepos();

        public BanBi_AServices()
        {
        }

        public BanBi_AServices(BanBi_aRepos repos)
        {
            _repos = repos;
        }

        public List<BanBium> GetAll()
        {
            return _repos.GetAll();
        }
        public bool Create(BanBium obj)
        {
            return _repos.Create(obj);
        }

        public bool Delete(int Id)
        {
            return _repos.Delete(Id);
        }



        public bool Update(int Id, BanBium obj)
        {
            return _repos.Update(Id, obj);
        }
    }
}
