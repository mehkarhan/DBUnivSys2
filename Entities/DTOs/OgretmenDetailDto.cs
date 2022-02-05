using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class OgretmenDetailDto:IDto
    {
        public int OgretmenID { get; set; }
        public string OgretmenAdi { get; set; }
        public string OgretmenSoyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciParola { get; set; }
        public int KullaniciID { get; set; }
    }
}
