using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Fashionista.core.Common
{
   public interface IdbContext
    {
        public DbConnection connection { get; }
    }
}
