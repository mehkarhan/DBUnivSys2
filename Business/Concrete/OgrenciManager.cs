using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        public void Add(Ogrenci ogrenci)
        {
            _ogrenciDal.Add(ogrenci);
        }

        public void Delete(Ogrenci ogrenci)
        {
            _ogrenciDal.Delete(ogrenci);
        }

        public List<Ogrenci> GetAll()
        {
            return _ogrenciDal.GetAll();
        }

        public List<Ogrenci> GetAllByID(int id)
        {
            return _ogrenciDal.GetAll(o=>o.KullaniciID==id);
        }

        public Ogrenci GetByID(int kid)
        {
            return _ogrenciDal.Get(o => o.KullaniciID == kid);
        }

        public Ogrenci GetByKayit(string adi, string soyadi)
        {
            return _ogrenciDal.Get(o => o.OgrenciAdi == adi && o.OgrenciSoyadi == soyadi);
        }

        public List<OgrenciDetailDto> GetDersDetails()
        {
            return _ogrenciDal.GetOgrenciDetail();
        }

       

        public List<OgrenciDetailDto> GetOgrencilerDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Ogrenci ogrenci)
        {
            _ogrenciDal.Update(ogrenci);
        }

        
    }
}
