using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public List<Role> GetAll()
        {
            return _roleDal.GetAll();
        }

        public List<Role> GetByID(int kid)
        {
            return _roleDal.GetAll(r=>r.RoleID==kid);
        }

        public Role getID(int kid)
        {
            return _roleDal.Get(r => r.RoleID == kid);
        }
    }
}
