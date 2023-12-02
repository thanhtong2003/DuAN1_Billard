using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IParterServices
    {
        public List<Partner> GetAll();
        public bool Create(Partner obj);
        public bool Update(int Id, Partner obj);
        public bool Delete(int Id);
    }
}
