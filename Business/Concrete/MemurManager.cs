using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MemurManager : IMemurService
    {
        IMemurDal _memurDal;

        public MemurManager(IMemurDal memurDal)
        {
            _memurDal = memurDal;
        }

        public void Add(Memur memur)
        {
            _memurDal.Add(memur);
        }

        public void Delete(Memur memur)
        {
            _memurDal.Delete(memur);
        }

        public List<Memur> GetAll()
        {
            return _memurDal.GetAll();
        }


        public List<Memur> GetAllByID(int id)
        {
            return _memurDal.GetAll(m=>m.KullaniciID==id);
        }

        public Memur GetbyID(int id)
        {
            return _memurDal.Get(m => m.KullaniciID == id);
        }

        public List<MemurDetailDto> GetMemurDetail()
        {
            return _memurDal.GetMemurDetails();
        }

        public void Update(Memur memur)
        {
            _memurDal.Update(memur);
        }
    }
}
