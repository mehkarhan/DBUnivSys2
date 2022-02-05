using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISinifService
    {
        List<Sinif> GetAll();
        Sinif GetByID(int sinifID);
    }
}
