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
   public class FroleRepository : IFroleRepository
    {
        private readonly IdbContext context;
        public FroleRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool Delete_Role(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Role", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("FRole_Package.Delete_Role", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Frole> Get_All_Rolle()
        {
            IEnumerable<Frole> result = context.connection.Query<Frole>("FRole_Package.Get_All_Rolle", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Frole Get_Rolle_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Role", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Frole>("FRole_Package.Get_Rolle_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public string Insert_Role(Frole role)
        {
            var p = new DynamicParameters();

            p.Add("Id_Of_Role", role.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Type_Of_Role", role.Type, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("FRole_Package.Insert_Role", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Role(Frole role)
        {
            var p = new DynamicParameters();

            p.Add("Id_Of_Role", role.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Type_Of_Role", role.Type, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("FRole_Package.Update_Role", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
