using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOgretmenDal : EfEntityRepositoryBase<Ogretmen, UnivContext>, IOgretmenDal
    {
        public List<OgretmenDetailDto> GetOgretmenDetails()
        {
            using (UnivContext context=new UnivContext())
            {
                var result = from o in context.Ogretmens
                             join k in context.Kullanicis
                             on o.KullaniciID equals k.KullaniciID
                             select new OgretmenDetailDto
                             {
                                 OgretmenID = o.OgretmenID,
                                 OgretmenAdi = o.OgretmenAdi,
                                 OgretmenSoyadi = o.OgretmenSoyadi,
                                 KullaniciAdi = k.KullaniciAdi,
                                 KullaniciParola = k.KullaniciParola,
                                 KullaniciID=k.KullaniciID
                                 
                             };
                return result.ToList();
            }
        }
    }
}
