using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public void Add(Kullanici kullanici)
        {
            _kullaniciDal.Add(kullanici);
        }

        public void Delete(Kullanici kullanici)
        {
            _kullaniciDal.Delete(kullanici);
        }

        public List<Kullanici> GetAll()
        {
            return _kullaniciDal.GetAll();
        }

        public Kullanici GetByID(int id)
        {
            return _kullaniciDal.Get(k=>k.KullaniciID==id);
        }

        public Kullanici GetLogin(string kadi, string pass)
        {
            return _kullaniciDal.Get(k => k.KullaniciAdi == kadi && k.KullaniciParola == pass);
        }

        public void Update(Kullanici kullanici)
        {
            _kullaniciDal.Update(kullanici);
        }
    }
}
