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
    public class MemberServices : IMemberServices
    {
        MemberRepos _repos = new MemberRepos();

        public MemberServices()
        {
        }

        public MemberServices(MemberRepos repos)
        {
            _repos = repos;
        }

        public bool Create(MemBerShip obj)
        {
            return _repos.Create(obj);
        }

        public bool Delete(int id)
        {
            return _repos.Delete(id);
        }

        public List<MemBerShip> GetAll()
        {
           return _repos.GetAll();
        }

        public bool Update(int id, MemBerShip obj)
        {
            return _repos.Update(id, obj);
        }
    }
}
