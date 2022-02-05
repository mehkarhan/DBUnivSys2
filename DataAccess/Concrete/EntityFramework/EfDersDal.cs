using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDersDal : EfEntityRepositoryBase<Ders, UnivContext>, IDersDal
    {
        public List<DersDetailDto> GetDersDetails()
        {
            using (UnivContext context=new UnivContext())
            {
                var result = from d in context.Derss
                             join b in context.Bolums
                             on d.BolumID equals b.BolumID
                             join s in context.Sinifs
                             on d.SinifID equals s.SinifID
                             join donem in context.Donems
                             on d.SinifID equals donem.DonemID
                             select new DersDetailDto
                             {
                                 DersAdi=d.DersAdi,BolumAdi=b.BolumAdi,
                                 SinifAdi=s.SinifAdi,DonemAdi=donem.DonemAdi
                             };
                return result.ToList();
            }
           
        }
    }
}
