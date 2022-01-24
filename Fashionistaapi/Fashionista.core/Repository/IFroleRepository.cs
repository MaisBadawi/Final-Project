using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
   public interface IFroleRepository
    {
        public string Insert_Role(Frole role);
        public bool Delete_Role(int id);
        public bool Update_Role(Frole role);
        public List<Frole> Get_All_Rolle();
        public Frole Get_Rolle_By_Id(int id);
    }
}
