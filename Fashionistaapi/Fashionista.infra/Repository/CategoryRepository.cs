using Dapper;
using Fashionista.core.Common;
using Fashionista.core.Data;
using Fashionista.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fashionista.infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IdbContext context;
        public CategoryRepository(IdbContext context)
        {
            this.context = context;
        }
        
        
        public bool Delete_Category_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Category", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Category_Package.Delete_Category_By_Id", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Category> Get_All_Category()
        {
            IEnumerable<Category> result = context.connection.Query<Category>("Category_Package.Get_All_Category", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Category Get_Category_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Category", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Category>("Category_Package.Get_Category_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Category Get_Category_By_Name(string nameOfCAtegory)
        {
            var p = new DynamicParameters();
            p.Add("Name_OF_Category", nameOfCAtegory, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Category>("Category_Packagee.Get_Category_By_Name", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public string Insert_Category(Category cat)
        {
            var p = new DynamicParameters();

            p.Add("Name_OF_Category",cat.Name , dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Image", cat.ImagePath, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Category_Package.Insert_Category", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Category(Category cat)
        {
            var p = new DynamicParameters();

            p.Add("Id_Of_Category", cat.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Name_OF_Category", cat.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Image", cat.ImagePath, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Category_Package.Update_Category", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
