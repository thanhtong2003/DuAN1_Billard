using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IBanBi_ARepos
    {
        public List<BanBium> GetAll();
        public bool Create(BanBium obj);
        public bool Update(int Id, BanBium obj);
        public bool Delete(int Id);
    }
}
