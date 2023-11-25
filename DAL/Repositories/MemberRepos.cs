using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MemberRepos : IMemberRepos
    {
        ERD_QLBIDAContext _dbContext = new ERD_QLBIDAContext();

        public MemberRepos()
        {
        }

        public MemberRepos(ERD_QLBIDAContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Create(MemBerShip obj)
        {
            try
            {
                _dbContext.MemBerShips.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var xoa = _dbContext.MemBerShips.Find(id);
                _dbContext.Remove(xoa);
                _dbContext.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public List<MemBerShip> GetAll()
        {
            return _dbContext.MemBerShips.ToList();
        }

        public bool Update(int id, MemBerShip obj)
        {
            try
            {
                var suaObj = _dbContext.MemBerShips.Find(id);
                suaObj.NgayGiaNhap = obj.NgayGiaNhap;
                suaObj.NgayHetHan = obj.NgayHetHan;
                suaObj.LoaiTheThanhVien = obj.LoaiTheThanhVien;
                suaObj.PhanTramGiam = obj.PhanTramGiam;
                _dbContext.Update(suaObj);
                _dbContext.SaveChanges();
                return true;
                    
            }catch (Exception ex) { return false; }
        }
    }
}
