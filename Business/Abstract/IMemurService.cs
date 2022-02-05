using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IMemurService
    {
        List<Memur> GetAll();
        List<Memur> GetAllByID(int id);
        void Add(Memur memur);
        void Update(Memur memur);
        void Delete(Memur memur);
        Memur GetbyID(int id);
        List<MemurDetailDto> GetMemurDetail();
        
    }
}
