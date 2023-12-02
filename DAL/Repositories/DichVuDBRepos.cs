using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DichVuDBRepos : IDichVuDBRepos
    {
        ERD_QLBIDAContext _contex = new ERD_QLBIDAContext();

        public DichVuDBRepos()
        {
        }
        public DichVuDBRepos(ERD_QLBIDAContext contex)
        {
            _contex = contex;
        }

        public bool Create(DichVuDb dichVu)
        {
            try
            {
                 _contex.DichVuDbs.Add(dichVu);
                _contex.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                var resurl = _contex.DichVuDbs.FirstOrDefault(x => x.IddichVuDb == Id);
                if (resurl != null)
                {
                    _contex.DichVuDbs.Remove(resurl);
                    _contex.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public List<DichVuDb> GetAll()
        {
            return _contex.DichVuDbs.ToList();
        }

        public bool Update(int Id, DichVuDb dichVu)
        {
            try
            {
                var resurl = _contex.DichVuDbs.FirstOrDefault(x => x.IddichVuDb == Id);
                if (resurl != null)
                {
                    resurl.TenDichVuDb = dichVu.TenDichVuDb;
                    resurl.IdloaiDichVu = dichVu.IdloaiDichVu;
                    resurl.MoTa = dichVu.MoTa;
                    resurl.DonGia = dichVu.DonGia;
                    _contex.DichVuDbs.Update(resurl);
                    _contex.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
