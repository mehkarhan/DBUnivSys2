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
    public class EfOgrenciDal : EfEntityRepositoryBase<Ogrenci, UnivContext>, IOgrenciDal
    {
        public List<OgrenciDetailDto> GetOgrenciDetail()
        {
            using (UnivContext context = new UnivContext())
            {
                var result = from o in context.Ogrencis
                             join k in context.Kullanicis
                             on o.KullaniciID equals k.KullaniciID
                             join r in context.Roles
                             on k.RoleID equals r.RoleID
                             select new OgrenciDetailDto
                             {
                                 OgrenciID = o.OgrenciID,
                                 OgrenciAdi = o.OgrenciAdi,
                                 OgrenciSoyadi = o.OgrenciSoyadi,
                                 KullaniciAdi = k.KullaniciAdi,
                                 KullaniciParola = k.KullaniciParola,
                             };
                return result.ToList();
            }
        }

        
    }
}
