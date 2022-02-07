using Dapper;
using Fashionista.core;
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
   public class AgeRepository : IAgeRepository
    {
        private readonly IdbContext context;
        public AgeRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool Delete_Age(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID_Age", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Age_Package.Delete_Age", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public Age Get_Age_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID_Age", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Age>("Age_Package.Get_Age_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public List<Age> GET_All_Age()
        {
            IEnumerable<Age> result = context.connection.Query<Age>("Age_Package.GET_All_Age", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string Insert_Age(Age age)
        {
            var p = new DynamicParameters();

            p.Add("Age_Group", age.AGE_PERIOD, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("A_StartAge", age.START_AGE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("A_EndAge", age.END_AGE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Age_Package.Insert_Age", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Age(Age age)
        {
            var p = new DynamicParameters();
            p.Add("ID_Age", age.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Age_Group", age.AGE_PERIOD, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("A_StartAge", age.START_AGE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("A_EndAge", age.END_AGE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Age_Package.Update_Age", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
