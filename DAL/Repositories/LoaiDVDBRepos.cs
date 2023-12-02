using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LoaiDVDBRepos : ILoaiDVDBRepos
    {
        ERD_QLBIDAContext _contex = new ERD_QLBIDAContext();
        public LoaiDVDBRepos()
        {
        }
        public LoaiDVDBRepos(ERD_QLBIDAContext contex)
        {
            _contex = contex;
        }

        public bool Create(LoaiDichVuDb obj)
        {
            try
            {
                _contex.LoaiDichVuDbs.Add(obj);
                _contex.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var obj = _contex.LoaiDichVuDbs.FirstOrDefault(x => x.IdloaiDichVuDb == id);
                if (obj != null)
                {
                    _contex.LoaiDichVuDbs.Remove(obj);
                    _contex.SaveChanges();
                    return true;
                }
                return false;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public List<LoaiDichVuDb> GetAll()
        {
            return _contex.LoaiDichVuDbs.ToList();
        }

        public string GetByName(int Id)
        {
            var obj = _contex.LoaiDichVuDbs.Find(Id);
            if(obj != null)
            {
                return obj.TenLoaiDichVuDb;
            }
            return "loại dịch vụ DDB không tồn tại";
        }

        public int GetIdByName(string name)
        {
            Console.WriteLine("Tên loại: " + name);
            var obj = _contex.LoaiDichVuDbs.FirstOrDefault(x => x.TenLoaiDichVuDb == name);
            if (obj != null)
            {
                return obj.IdloaiDichVuDb;
            }
            return 0;
        }


        public bool Update(int id, LoaiDichVuDb obj)
        {
            try
            {
                var updateObj = _contex.LoaiDichVuDbs.FirstOrDefault(x => x.IdloaiDichVuDb == id);
                if (updateObj != null)
                {
                    updateObj.TenLoaiDichVuDb = obj.TenLoaiDichVuDb;
                    updateObj.MoTa = obj.MoTa;
                    _contex.LoaiDichVuDbs.Update(updateObj);
                    _contex.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
