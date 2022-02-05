using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Memur : IEntity
    {
     
        public int MemurID { get; set; }
        public string MemurAdi { get; set; }
        public string MemurSoyadi { get; set; }
        public int KullaniciID { get; set; }

    }
}
