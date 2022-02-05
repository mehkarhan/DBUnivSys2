using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class TumOgrenciDto:IDto
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciParola{ get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }


    }
}
