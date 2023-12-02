using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IPartnerRepos
    {
        public List<Partner> GetAll();
        public bool Create(Partner obj);
        public bool Update(int Id, Partner obj);
        public bool Delete(int Id);
    }
}
