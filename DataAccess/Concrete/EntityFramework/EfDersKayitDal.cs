using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDersKayitDal : EfEntityRepositoryBase<DersKayit, UnivContext>, IDersKayitDal
    {
        public List<OgrenciDers> GetOgrenciDers()
        {
            using (UnivContext context=new UnivContext())
            {
                var result = from dk in context.DersKayits
                             join o in context.Ogrencis
                             on dk.OgrenciID equals o.OgrenciID
                             join d in context.Derss
                             on dk.DersID equals d.DersID
                             join k in context.Kullanicis
                             on o.KullaniciID equals k.KullaniciID
                             select new OgrenciDers
                             {
                                 KullaniciID=k.KullaniciID,
                                 OgrenciID=o.OgrenciID,
                                 OgrenciAdi = o.OgrenciAdi,
                                 OgrenciSoyadi = o.OgrenciSoyadi,
                                 DersAdi = d.DersAdi


                             };
                return result.ToList();
            }
        }

        public List<OgrenciDers> GetOgrenciDetails(Ogrenci ogrenci)
        {
            using (UnivContext context = new UnivContext())
            {
                var result = from dk in context.DersKayits
                             join d in context.Derss
                             on dk.DersID equals d.DersID
                             where dk.DersID == d.DersID && dk.OgrenciID== ogrenci.OgrenciID
                             
                             select new OgrenciDers
                             {
                                 
                                 OgrenciID=dk.OgrenciID,
                                 DersAdi = d.DersAdi,
                                 OgrenciAdi=ogrenci.OgrenciAdi,
                                 OgrenciSoyadi=ogrenci.OgrenciSoyadi
                                

                             };
                return result.ToList();
            }
        }
    }
}
