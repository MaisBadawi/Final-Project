using Fashionista.core.Data;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
   public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository catRepository;
        public CategoryService(ICategoryRepository catRepository)
        {
            this.catRepository = catRepository;
        }

        public bool Delete_Category_By_Id(int id)
        {
            return catRepository.Delete_Category_By_Id(id);
        }

        public List<Category> Get_All_Category()
        {
            return catRepository.Get_All_Category();
        }

        public Category Get_Category_By_Id(int id)
        {
            return catRepository.Get_Category_By_Id(id);        }

        public Category Get_Category_By_Name(string nameOfCAtegory)
        {
            return catRepository.Get_Category_By_Name(nameOfCAtegory);        }

        public string Insert_Category(Category cat)
        {
            return catRepository.Insert_Category(cat);
        }

        public bool Update_Category(Category cat)
        {
            return catRepository.Update_Category(cat);
        }
    }
}
