using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class DersKayit : IEntity
    {
 
        public int DersKayitID { get; set; }
        public int DersID { get; set; }

        public int OgrenciID { get; set; }

        public bool DersKayitOnay { get; set; }
        
    }
}
