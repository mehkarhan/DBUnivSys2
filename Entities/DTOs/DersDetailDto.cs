using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DersDetailDto:IDto
    {
        public string DersAdi { get; set; }
        public string BolumAdi { get; set; }
        public string SinifAdi { get; set; }
        public string DonemAdi { get; set; }
    }
}
