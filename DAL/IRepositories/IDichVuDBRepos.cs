using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IDichVuDBRepos
    {
        public List<DichVuDb> GetAll();
        public bool Create(DichVuDb dichVu);
        public bool Update(int Id,  DichVuDb dichVu);
        public bool Delete(int Id);
    }
}
