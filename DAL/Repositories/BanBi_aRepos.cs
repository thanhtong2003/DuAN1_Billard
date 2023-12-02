using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BanBi_aRepos : IBanBi_ARepos
    {
        ERD_QLBIDAContext _contex = new ERD_QLBIDAContext();

        public BanBi_aRepos() { }

        public BanBi_aRepos(ERD_QLBIDAContext contex)
        {
            _contex = contex;
        }

        public List<BanBium> GetAll()
        {
            return _contex.BanBiAs.ToList();
        }
        public bool Create(BanBium obj)
        {
            try
            {
                _contex.BanBiAs.Add(obj);
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
                var xoaObj = _contex.BanBiAs.FirstOrDefault(x => x.IdbanBiA == Id);
                if (xoaObj != null)
                {
                    _contex.Remove(xoaObj);
                    _contex.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool Update(int Id, BanBium obj)
        {
            try
            {
                var update = _contex.BanBiAs.FirstOrDefault(x => x.IdbanBiA == Id);
                update.CapBanBiA = obj.CapBanBiA;
                update.LoaiBanBiA = obj.LoaiBanBiA;
                update.TenBanBiA = obj.TenBanBiA;
                update.TrangThai = obj.TrangThai;
                update.DonGia = obj.DonGia;

                _contex.Update(update);
                _contex.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
