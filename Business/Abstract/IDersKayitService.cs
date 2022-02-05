using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDersKayitService
    { 
        void Add(DersKayit dersKayit);

        void Update(DersKayit dersKayit);
        void Delete(DersKayit dersKayit);
        List<OgrenciDers> GetOgrenciDers();
        List<OgrenciDers> GetOgrenciDetail(Ogrenci ogrenci);
        List<DersKayit> GetAll();
        

        DersKayit GetByID(int ogrenciID);

       


    }
}
