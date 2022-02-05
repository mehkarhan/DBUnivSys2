using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Not : IEntity
    {
     
        public int NotID { get; set; }
        public double NotVize { get; set; }
        public double  NotFinal { get; set; }

        public int DersID { get; set; }
 
        public int OgrenciID { get; set; }
        public double NotButunleme { get; set; }
    }
}
