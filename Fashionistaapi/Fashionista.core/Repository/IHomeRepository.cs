using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
   public interface IHomeRepository
    {
        public List<home> GET_All_Home();
    }
}
