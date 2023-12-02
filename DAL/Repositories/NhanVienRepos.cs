using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NhanVienRepos : INhanVienRepos
    {
        ERD_QLBIDAContext _context = new ERD_QLBIDAContext();

        public NhanVienRepos()
        {
        }

        public NhanVienRepos(ERD_QLBIDAContext context)
        {
            _context = context;
        }

        public List<NhanVien> GetAll()
        {
            return _context.NhanViens.ToList();
        }
        public bool Create(NhanVien nhanVien)
        {
            try
            {
                _context.NhanViens.Add(nhanVien);
                _context.SaveChanges();
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
                var xoa = _context.NhanViens.FirstOrDefault(x => x.IdnhanVien == Id);
                if (xoa != null)
                {
                    _context.NhanViens.Remove(xoa);
                    _context.SaveChanges();
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool Update(int Id, NhanVien nhanVien)
        {
            try
            {
                var updateNV = _context.NhanViens.FirstOrDefault(x => x.IdnhanVien == Id);
                updateNV.IdchucVu = nhanVien.IdchucVu;
                updateNV.TenNhanVien = nhanVien.TenNhanVien;
                updateNV.TenDangNhap = nhanVien.TenDangNhap;
                updateNV.DiaChi = nhanVien.DiaChi;
                updateNV.SoDienThoai = nhanVien.SoDienThoai;
                updateNV.GioiTinh = nhanVien.GioiTinh;
                updateNV.NgaySinh = nhanVien.NgaySinh;
                updateNV.TrangThai = nhanVien.TrangThai;
                updateNV.MatKhau = nhanVien.MatKhau;
                updateNV.Email = nhanVien.Email;
                _context.NhanViens.Update(updateNV);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
