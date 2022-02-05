using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public List<Admin> GetByID(int id)
        {
            return _adminDal.GetAll(a => a.AdminID == id);
        }

        public Admin GetbyKullaniciID(int id)
        {
            return _adminDal.Get(a => a.KullaniciID == id);
        }

        
    }
}
