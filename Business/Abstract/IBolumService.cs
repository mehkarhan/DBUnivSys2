using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBolumService
    {
        List<Bolum> GetAll();

        Bolum GetByID(int bolumID);
        
    }
}
