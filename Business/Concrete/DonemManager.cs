using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DonemManager : IDonemService
    {
        IDonemDal _donemDal;

        public DonemManager(IDonemDal donemDal)
        {
            _donemDal = donemDal;
        }

        public List<Donem> GetAll()
        {
            return _donemDal.GetAll();
        }

        public Donem GetByID(int donemID)
        {
            return _donemDal.Get(d => d.DonemID == donemID);
        }
    }
}
