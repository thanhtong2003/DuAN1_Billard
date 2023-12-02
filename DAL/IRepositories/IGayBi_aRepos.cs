using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IGayBi_aRepos
    {
        public List<GayBium> GetAll();
        public bool Create(GayBium obj);
        public bool Update(int id, GayBium obj);
        public bool Delete(int Id);
    }
}
