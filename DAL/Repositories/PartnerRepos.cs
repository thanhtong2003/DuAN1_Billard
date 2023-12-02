using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PartnerRepos : IPartnerRepos
    {
        ERD_QLBIDAContext _contex = new ERD_QLBIDAContext();

        public PartnerRepos()
        {
        }

        public PartnerRepos(ERD_QLBIDAContext contex)
        {
            _contex = contex;
        }

        public List<Partner> GetAll()
        {
            return _contex.Partners.ToList();
        }
        public bool Create(Partner obj)
        {
            try
            {
                _contex.Partners.Add(obj);
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
                var xoaObj = _contex.Partners.FirstOrDefault(X => X.Idpartner == Id);
                _contex.Partners.Remove(xoaObj);
                _contex.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool Update(int Id, Partner obj)
        {
            try
            {
                var updateObj = _contex.Partners.FirstOrDefault(x => x.Idpartner == Id);
                updateObj.TenPatrner = obj.TenPatrner;
                updateObj.LoaiPartner = obj.LoaiPartner;
                updateObj.DonGia = obj.DonGia;
                updateObj.TrangThai = obj.TrangThai;
                _contex.Partners.Update(updateObj);
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
