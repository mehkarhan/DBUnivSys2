using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IDersService
    {
        List<Ders> GetAll();

        Ders GetByID(int dersID);
        List<DersDetailDto> GetDersDetails();
        List<Ders> GetbyDers(int bolum,int sınıf ,int donem );
        List<Ders> GetBySinif(int sinifID);

        Ders GetbyAdi(string dersAdi);

       

    }
}
