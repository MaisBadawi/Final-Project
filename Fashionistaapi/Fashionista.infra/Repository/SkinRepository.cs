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
   public class SkinRepository : ISkinRepository
    {
        private readonly IdbContext context;
        public SkinRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool delete_Skin(int id)
        {
            var p = new DynamicParameters();
            p.Add("Skin_ID", p, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Skin_Package.delete_Skin", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Skin> getall_Skin()
        {
            IEnumerable<Skin> result = context.connection.Query<Skin>("Skin_Package.getall_Skin", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Skin get_Skin_By_id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Skin_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Skin>("Skin_Package.get_Skin_By_id", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }


        public string insert_Skin(Skin skin)
        {
            var p = new DynamicParameters();

            p.Add("SkinColor", skin.Color_Skin, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Skin_Package.insert_Skin", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool update_Skin(Skin skin)
        {
            var p = new DynamicParameters();
            p.Add("Skin_ID", skin.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SkinColor", skin.Color_Skin, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Skin_Package.update_Skin", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
