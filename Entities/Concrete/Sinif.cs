using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sinif : IEntity
    {
     
        public int SinifID { get; set; }
       
        public string SinifAdi { get; set; }
  
    }
}
