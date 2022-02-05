using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OgretmenManager : IOgretmenService
    {
        IOgretmenDal _ogretmenDal;

        public OgretmenManager(IOgretmenDal ogretmenDal)
        {
            _ogretmenDal = ogretmenDal;
        }

        public void Add(Ogretmen ogretmen)
        {
            _ogretmenDal.Add(ogretmen);
        }

        public void Delete(Ogretmen ogretmen)
        {
            _ogretmenDal.Delete(ogretmen);
        }

        public List<Ogretmen> GetAll()
        {
            return _ogretmenDal.GetAll();
        }

        public List<Ogretmen> GetAllByID(int id)
        {
            return _ogretmenDal.GetAll(o => o.KullaniciID == id);
        }

        

        public Ogretmen GetbyID(int id)
        {
            return _ogretmenDal.Get(o=>o.KullaniciID==id);
        }

        public List<OgretmenDetailDto> GetOgretmenDetails()
        {
            return _ogretmenDal.GetOgretmenDetails();
        }

        public void Update(Ogretmen ogretmen)
        {
            _ogretmenDal.Update(ogretmen);
        }
    }
}
