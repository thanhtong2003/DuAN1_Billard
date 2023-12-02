using DAL.IRepositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ChucVuRepos : IChucVuRepos
    {
        ERD_QLBIDAContext _contex = new ERD_QLBIDAContext();

        public ChucVuRepos()
        {
        }

        public ChucVuRepos(ERD_QLBIDAContext contex)
        {
            _contex = contex;
        }

        public List<ChucVu> GetAll()
        {
            return _contex.ChucVus.ToList();
        }
        public bool Create(ChucVu chucVu)
        {
            try
            {
                _contex.ChucVus.Add(chucVu);
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
                var DeleteObj = _contex.ChucVus.FirstOrDefault(x => x.IdchucVu == Id);
                if (DeleteObj != null)
                {
                    _contex.ChucVus.Remove(DeleteObj);
                    _contex.SaveChanges();
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool Update(int Id, ChucVu chucVu)
        {
            try
            {
                var DeleteObj = _contex.ChucVus.FirstOrDefault(x => x.IdchucVu == Id);
                if (DeleteObj != null)
                {
                    DeleteObj.TenChucVu = chucVu.TenChucVu;
                    _contex.SaveChanges();
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string GetTenChucVu(int Id)
        {
            var chucVu = _contex.ChucVus.Find(Id);

            // Kiểm tra xem chucVu có tồn tại hay không
            if (chucVu != null)
            {
                return chucVu.TenChucVu;
            }

            return "Chức vụ không tồn tại";
        }
        public int GetIdByTenChucVu(string tenChucVu)
        {
            var chucVu = _contex.ChucVus.FirstOrDefault(x => x.TenChucVu == tenChucVu);

            // Kiểm tra xem chucVu có tồn tại hay không
            if (chucVu != null)
            {
                return chucVu.IdchucVu;
            }

            return 0; // Hoặc có thể trả về một giá trị mặc định khác
        }

    }
}
