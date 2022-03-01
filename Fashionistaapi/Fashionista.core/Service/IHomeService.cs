using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
  public  interface IHomeService
    {
        public List<home> GET_All_Home();
    }
}
