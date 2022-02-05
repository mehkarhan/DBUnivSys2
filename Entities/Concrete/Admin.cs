using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Admin:IEntity
    {
        public int AdminID { get; set; }
        public string AdminAdi { get; set; }
        public string AdminSoyadi{ get; set; }
        public int KullaniciID { get; set; }
    }
}
