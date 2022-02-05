using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IAdminService
    {
        List<Admin> GetAll();

        List<Admin> GetByID(int id);
        Admin GetbyKullaniciID(int id);
    }
}
