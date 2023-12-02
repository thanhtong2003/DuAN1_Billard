using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KhuyenMaiRepos : IKhuyenMaiRepos
    {
        ERD_QLBIDAContext _contex = new ERD_QLBIDAContext();

        public KhuyenMaiRepos()
        {
        }

        public KhuyenMaiRepos(ERD_QLBIDAContext contex)
        {
            _contex = contex;
        }

        public List<KhuyenMai> GetAll()
        {
            return _contex.KhuyenMais.ToList();
        }
        public bool Create(KhuyenMai obj)
        {
            try
            {
                _contex.KhuyenMais.Add(obj);
                _contex.SaveChanges();
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
                var obj = _contex.KhuyenMais.FirstOrDefault(x => x.IdkhuyenMai == id);
                if (obj != null)
                {
                    _contex.KhuyenMais.Remove(obj);
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

        

        public int GetIdByTenKhuyenMai(string tenKhuyenMai)
        {
            var khuyenMai = _contex.KhuyenMais.FirstOrDefault(x => x.TenKhuyenMai == tenKhuyenMai);
            if (khuyenMai != null)
            {
                return khuyenMai.IdkhuyenMai;
            }
            return 0;
        }

        public string GetTenKhuyenMai(int Id)
        {
             var khuyenMai = _contex.KhuyenMais.Find(Id);

            if (khuyenMai != null)
            {
                return khuyenMai.TenKhuyenMai;
            }
            return "Khuyến mãi không tồn tại";
        }

        public bool Update(int id, KhuyenMai obj)
        {
            try
            {
                var updateKM = _contex.KhuyenMais.FirstOrDefault(x => x.IdkhuyenMai == id);
                updateKM.TenKhuyenMai = obj.TenKhuyenMai;
                updateKM.MucGiam = obj.MucGiam;
                updateKM.NgayTao = obj.NgayTao;
                updateKM.NgayHetHan = obj.NgayHetHan;
                updateKM.TrangThai = obj.TrangThai;
                updateKM.SoLuong = obj.SoLuong;
                updateKM.GhiChu = obj.GhiChu;
                if (updateKM != null)
                {
                    _contex.KhuyenMais.Update(updateKM);
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
