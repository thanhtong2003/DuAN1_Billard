using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GayBi_aRepos : IGayBi_aRepos
    {
        ERD_QLBIDAContext _contex = new ERD_QLBIDAContext();

        public GayBi_aRepos()
        {
        }

        public GayBi_aRepos(ERD_QLBIDAContext contex)
        {
            _contex = contex;
        }

        public List<GayBium> GetAll()
        {
            return _contex.GayBiAs.ToList();
        }
        public bool Create(GayBium obj)
        {
            try
            {
                _contex.GayBiAs.Add(obj);
                _contex.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                var obj = _contex.GayBiAs.FirstOrDefault(x => x.IdgayBiA == Id);
                if (obj != null)
                {
                    _contex.GayBiAs.Remove(obj);
                    _contex.SaveChanges();
                    return true;
                }
                return false;
            }catch(Exception ex)
            {
                return false;
            }
        }

        

        public bool Update(int id, GayBium obj)
        {
            try
            {
                var suaObj = _contex.GayBiAs.FirstOrDefault(x => x.IdgayBiA == id);
                suaObj.TenGayBiA = obj.TenGayBiA;
                suaObj.LoaiGayBiA = obj.LoaiGayBiA;
                suaObj.DonGia = obj.DonGia;
                suaObj.TrangThai = obj.TrangThai;
                suaObj.SoLuong = obj.SoLuong;
                if(suaObj != null)
                {
                    _contex.GayBiAs.Update(suaObj);
                    _contex.SaveChanges();
                    return true;
                }
                return false;
            }catch (Exception ex)
            {
                return false;
            }
        }
    }
}
