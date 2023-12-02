using BUS.IServices;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanVienServices : INhanVienServices
    {
        NhanVienRepos _repos = new NhanVienRepos();

        public NhanVienServices()
        {
        }

        public NhanVienServices(NhanVienRepos repos)
        {
            _repos = repos;
        }
        public List<NhanVien> GetAll()
        {
            return _repos.GetAll();
        }

        public bool Create(NhanVien nhanVien)
        {
            return _repos.Create(nhanVien);
        }

        public bool Delete(int Id)
        {
            return _repos.Delete(Id);
        }



        public bool Update(int Id, NhanVien nhanVien)
        {
            return _repos.Update(Id, nhanVien);
        }
    }
}
