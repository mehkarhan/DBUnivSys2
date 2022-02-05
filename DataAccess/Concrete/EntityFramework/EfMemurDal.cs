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
    public class EfMemurDal : EfEntityRepositoryBase<Memur, UnivContext>, IMemurDal
    {
        public List<MemurDetailDto> GetMemurDetails()
        {
            using (UnivContext context=new UnivContext())
            {
                var result = from m in context.Memurs
                             join k in context.Kullanicis
                             on m.KullaniciID equals k.KullaniciID
                             select new MemurDetailDto
                             {
                                 KullaniciID = k.KullaniciID,
                                 MemurAdi = m.MemurAdi,
                                 MemurSoyadi = m.MemurSoyadi,
                                 KullaniciAdi = k.KullaniciAdi,
                                 KullaniciParola = k.KullaniciParola,
                                 MemurID=m.MemurID
                             };
                return result.ToList();
            }
        }
    }
}
