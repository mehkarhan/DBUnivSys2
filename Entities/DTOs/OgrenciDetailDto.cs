using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OgrenciDetailDto:IDto
    {
        public int OgrenciID { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciParola { get; set; }
        public int KullaniciID { get; set; }
        



    }
}
