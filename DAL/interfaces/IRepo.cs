﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
  public  interface IRepo<CLASS, ID>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        bool Create(CLASS obj);
        bool Update(CLASS obj);
        bool Delete(ID id);
    }
}
