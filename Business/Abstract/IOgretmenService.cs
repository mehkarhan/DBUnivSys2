using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOgretmenService
    {
        List<Ogretmen> GetAll();
        List<Ogretmen> GetAllByID(int id);
        void Add(Ogretmen ogretmen);
        void Update(Ogretmen ogretmen);
        void Delete(Ogretmen ogretmen);
        Ogretmen GetbyID(int id);
        List<OgretmenDetailDto> GetOgretmenDetails();    
        
    }
}
