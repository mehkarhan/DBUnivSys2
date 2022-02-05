using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Business.Concrete
{
    public class DersKayitManager : IDersKayitService
    {
        IDersKayitDal _dersKayitDal;

        public DersKayitManager(IDersKayitDal dersKayitDal)
        {
            _dersKayitDal = dersKayitDal;
        }

        public void Add(DersKayit dersKayit)
        {
            _dersKayitDal.Add(dersKayit);
        }

        public void Delete(DersKayit dersKayit)
        {
            _dersKayitDal.Delete(dersKayit);
        }

        public List<DersKayit> GetAll()
        {
            return _dersKayitDal.GetAll();
        }

        public List<OgrenciDers> GetOgrenciDers()
        {
            return _dersKayitDal.GetOgrenciDers();
        }

        public DersKayit GetByID(int ogrenciID)
        {
            return _dersKayitDal.Get(dk=>dk.OgrenciID==ogrenciID);
        }

        public void Update(DersKayit dersKayit)
        {
            _dersKayitDal.Update(dersKayit);
        }

        public List<OgrenciDers> GetOgrenciDetail(Ogrenci ogrenci)
        {
            var result = _dersKayitDal.GetOgrenciDetails(ogrenci);
            return result.ToList();
            
        }
    }
}
