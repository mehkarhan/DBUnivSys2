using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BolumManager : IBolumService
    {
        IBolumDal _bolumDal;

        public BolumManager(IBolumDal bolumDal)
        {
            _bolumDal = bolumDal;
        }

        public List<Bolum> GetAll()
        {
            return _bolumDal.GetAll();
        }

        public Bolum GetByID(int bolumID)
        {
            return _bolumDal.Get(b => b.BolumID == bolumID);
        }
    }
}
