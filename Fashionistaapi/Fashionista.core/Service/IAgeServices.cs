using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
   public interface IAgeServices
    {
        public string Insert_Age(Age age);//from service 
        public bool Delete_Age(int id);
        public bool Update_Age(Age age);

        public List<Age> GET_All_Age();


        public Age Get_Age_By_Id(int id);
    }
}
