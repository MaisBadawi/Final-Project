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
   public class StandaredSizeRepository : IStandaredSizeRepository
    {
        private readonly IdbContext context;
        public StandaredSizeRepository(IdbContext context)
        {
            this.context = context;
        }

        public StandaredSize Get_Size_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("S_Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<StandaredSize>("Size_Package.getsize_id", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public List<StandaredSize> GET_All_Size()
        {
            IEnumerable<StandaredSize> result = context.connection.Query<StandaredSize>("Size_Package.getall_Size", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string Insert_Size(StandaredSize size)
        {
            var p = new DynamicParameters();

            p.Add("SizeUK", size.SIZE_UK, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SizeEUR", size.SIZE_EUR, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SizeGeneral", size.SIZE_GENERAL, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("S_Max_Wieght", size.MAX_WIEGHT, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("S_Min_Wieght", size.MIN_WIEGHT, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("S_Max_Hight", size.MAX_HIGHE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("S_Min_Hight", size.MIN_WIEGHT, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Size_Package.insert_Size", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Size(StandaredSize size)
        {
            var p = new DynamicParameters();

            p.Add("S_Id", size.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SizeUK", size.SIZE_UK, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SizeEUR", size.SIZE_EUR, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SizeGeneral", size.SIZE_GENERAL, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("S_Max_Wieght", size.MAX_WIEGHT, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("S_Min_Wieght", size.MIN_WIEGHT, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("S_Max_Hight", size.MAX_HIGHE, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("S_Min_Hight", size.MIN_WIEGHT, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Size_Package.update_Size", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Delete_Size(int id)
        {
            var p = new DynamicParameters();
            p.Add("S_Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Size_Package.delete_Size", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
