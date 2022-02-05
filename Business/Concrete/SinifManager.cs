using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SinifManager : ISinifService
    {
        ISinifDal _sinifDal;

        public SinifManager(ISinifDal sinifDal)
        {
            _sinifDal = sinifDal;
        }

        public List<Sinif> GetAll()
        {
            return _sinifDal.GetAll();
        }

        public Sinif GetByID(int sinifID)
        {
            return _sinifDal.Get(s=>s.SinifID==sinifID);
        }
    }
}
