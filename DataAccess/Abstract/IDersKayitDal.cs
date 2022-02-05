using Core.DataAccess;
using Core.Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDersKayitDal : IEntityRepository<DersKayit>
    {
        List<OgrenciDers> GetOgrenciDers();
        List<OgrenciDers> GetOgrenciDetails(Ogrenci ogrenci);
       
        
        
    }
}
