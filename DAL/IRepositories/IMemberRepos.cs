using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IMemberRepos
    {
        public List<MemBerShip> GetAll();
        public bool Create(MemBerShip obj);
        public bool Update(int id, MemBerShip obj);
        public bool Delete(int id);
    }
}
