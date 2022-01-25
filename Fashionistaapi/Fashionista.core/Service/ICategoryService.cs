using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
   public interface ICategoryService
    {
        public string Insert_Category(Category cat);
        public bool Delete_Category_By_Id(int id);
        public bool Update_Category(Category cat);

        public List<Category> Get_All_Category();
        public Category Get_Category_By_Id(int id);
        public Category Get_Category_By_Name(string nameOfCAtegory);
    }
}
