using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class MemurDetailDto:IDto
    {
        public int MemurID { get; set; }
        public string MemurAdi { get; set; }
        public string MemurSoyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciParola { get; set; }
        public int KullaniciID { get; set; }
    }
}
