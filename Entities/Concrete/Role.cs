using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Role : IEntity
    {
   
        public int RoleID { get; set; }
 
        public string RoleAdi { get; set; }
   
    }
}
