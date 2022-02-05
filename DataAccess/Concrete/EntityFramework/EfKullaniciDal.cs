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
    public class EfKullaniciDal : EfEntityRepositoryBase<Kullanici, UnivContext>, IKullaniciDal
    {
        public List<TumOgrenciDto> tumOgrenciDtos()
        {
            using (UnivContext context=new UnivContext())
            {
                var result = from k in context.Kullanicis
                             join o in context.Ogrencis
                             on k.KullaniciID equals o.KullaniciID
                             join ogrt in context.Ogretmens
                             on k.KullaniciID equals ogrt.KullaniciID
                             join m in context.Memurs
                             on k.KullaniciID equals m.KullaniciID
                             select new TumOgrenciDto
                             {
                                 KullaniciID = k.KullaniciID,
                                 KullaniciAdi = k.KullaniciAdi,
                                 KullaniciParola = k.KullaniciParola,
                                 Adi = m.MemurAdi,
                                 Soyadi=o.OgrenciSoyadi,
                             };
                return result.ToList();   
                           

            }
        }
    }
}
