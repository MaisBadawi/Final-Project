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
    public class ProductColorRepository : IProductColorRepository
    {

        private readonly IdbContext context;
        public ProductColorRepository(IdbContext context)
        {
            this.context = context;
        }

        public bool Delete_Color(int id)
        {
            var p = new DynamicParameters();
            p.Add("Color_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Color_Package.delete_Color", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<ProductColor> Getall_Color()
        {
            IEnumerable<ProductColor> result = context.connection.Query<ProductColor>("Color_Package.getall_Color", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public ProductColor Get_Color_By_id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Color_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<ProductColor>("Color_Package.get_Color_By_id", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public string Insert_Color(ProductColor color)
        {
            var p = new DynamicParameters();

            p.Add("Color_Of_Product", color.COLOR_PRODUCT, dbType: DbType.String, direction: ParameterDirection.Input);
           
            var result = context.connection.ExecuteAsync("Color_Package.insert_Color", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool update_Color(ProductColor color)
        {
            var p = new DynamicParameters();

            p.Add("Color_ID", color.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Color_Of_Product", color.COLOR_PRODUCT, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Color_Package.update_Color", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
