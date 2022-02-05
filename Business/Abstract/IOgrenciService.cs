using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IOgrenciService
    {
        
        void Add(Ogrenci ogrenci);
        void Update(Ogrenci ogrenci);
        void Delete(Ogrenci ogrenci);
        Ogrenci GetByKayit(string adi, string soyadi);
        Ogrenci GetByID(int kid);
        List<Ogrenci> GetAll();
        //Ogrenci GetByID(int dersID);
        List<OgrenciDetailDto> GetOgrencilerDetail();
        

    }
}
