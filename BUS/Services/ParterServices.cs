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
    public class ParterServices : IParterServices
    {
        PartnerRepos _repos = new PartnerRepos();


        public ParterServices()
        {
        }

        public ParterServices(PartnerRepos repos)
        {
            _repos = repos;
        }

        public bool Create(Partner obj)
        {
            return _repos.Create(obj);
        }

        public bool Delete(int Id)
        {
            return (_repos.Delete(Id));
        }

        public List<Partner> GetAll()
        {
            return _repos.GetAll();
        }

        public bool Update(int Id, Partner obj)
        {
            return _repos.Update(Id, obj);
        }
    }
}
