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
    public class DichVuDBServices : IDichVuDBServices
    {
        DichVuDBRepos _repos = new DichVuDBRepos();

        public DichVuDBServices()
        {
        }

        public DichVuDBServices(DichVuDBRepos repos)
        {
            _repos = repos;
        }

        public bool Create(DichVuDb dichVu)
        {
            return _repos.Create(dichVu);
        }

        public bool Delete(int Id)
        {
           return (_repos.Delete(Id));
        }

        public List<DichVuDb> GetAll()
        {
           return _repos.GetAll();
        }

        public bool Update(int Id, DichVuDb dichVu)
        {
            return _repos.Update(Id, dichVu);
        }
    }
}
