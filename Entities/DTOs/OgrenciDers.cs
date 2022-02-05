using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OgrenciDers:IDto
    {
        public int KullaniciID { get; set; }
        public int OgrenciID { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string DersAdi { get; set; }
    }
}
