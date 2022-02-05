using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRoleService
    {
        List<Role> GetAll();
        Role getID(int kid);
        List<Role> GetByID(int kid);
    }
}
