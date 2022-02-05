using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanici> GetAll();

        Kullanici GetByID(int id);
        Kullanici GetLogin(string kadi, string pass);
        void Add(Kullanici  kullanici);
        
        void Update(Kullanici kullanici);
        void Delete(Kullanici kullanici);
        

    }
}
