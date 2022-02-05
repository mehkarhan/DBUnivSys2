using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ogretmen : IEntity
    {
        
        public int OgretmenID { get; set; }
        public string OgretmenAdi { get; set; }
        public string OgretmenSoyadi { get; set; }
        public int KullaniciID { get; set; }
    }
}
