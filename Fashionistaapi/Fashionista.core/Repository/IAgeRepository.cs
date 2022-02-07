using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
   public interface IAgeRepository
    {
        public bool Delete_Age(int id);


        public Age Get_Age_By_Id(int id);


        public List<Age> GET_All_Age();


        public string Insert_Age(Age age);


        public bool Update_Age(Age age);
        
    }
}
