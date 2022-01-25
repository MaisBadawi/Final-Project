using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
  public interface IStandaredSizeRepository
    {
        public string Insert_Size(StandaredSize size);
        public bool Delete_Size(int id);
        public bool Update_Size(StandaredSize size);
        public List<StandaredSize> GET_All_Size();
        public StandaredSize Get_Size_By_Id(int id);

    }
}
