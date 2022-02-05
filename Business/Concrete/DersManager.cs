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
    public class DersManager : IDersService
    {
        IDersDal _dersDal;

        public DersManager(IDersDal dersDal)
        {
            _dersDal = dersDal;
        }

        public List<Ders> GetAll()
        {
            return _dersDal.GetAll();
        }

        public Ders GetbyAdi(string dersAdi)
        {
           return _dersDal.Get(d=>d.DersAdi==dersAdi);
        }

        public List<Ders> GetbyDers(int bolum, int sinif, int donem)
        {
            return _dersDal.GetAll(d => d.BolumID == bolum && d.SinifID == sinif && d.DonemID == donem);
        }

        public Ders GetByID(int dersID)
        {
            return _dersDal.Get(d=>d.DersID==dersID);
        }

        public List<Ders> GetBySinif(int sinifID)
        {
            return _dersDal.GetAll(d=>d.SinifID==sinifID);
        }

        public List<DersDetailDto> GetDersDetails()
        {
            return _dersDal.GetDersDetails();
        }
    }
}
