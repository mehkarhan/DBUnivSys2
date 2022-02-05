using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ders : IEntity
    {
    
        public int DersID { get; set; }
      
        public string DersAdi { get; set; }
        public int BolumID { get; set; }
  
        public int SinifID { get; set; }
   
        public int DonemID { get; set; }
      

    }
}
