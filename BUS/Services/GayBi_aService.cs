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
    public class GayBi_aService : IGayBi_aService
    {
        GayBi_aRepos _repos = new GayBi_aRepos();

        public GayBi_aService()
        {
        }

        public GayBi_aService(GayBi_aRepos repos)
        {
            _repos = repos;
        }

        public List<GayBium> GetAll()
        {
            return _repos.GetAll();
        }
        public bool Create(GayBium obj)
        {
            return _repos.Create(obj);
        }

        public bool Delete(int Id)
        {
           return _repos.Delete(Id);
        }

        public bool Update(int id, GayBium obj)
        {
            return _repos.Update(id, obj);
        }
    }
}
