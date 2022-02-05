using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Ogrenci : IEntity
    {
        
        public int OgrenciID { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public int KullaniciID { get; set; }
        public int KayitYili { get; set; }


    }
}
