using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IDonemService
    {
        List<Donem> GetAll();
        Donem GetByID(int donemID);
    }
}
