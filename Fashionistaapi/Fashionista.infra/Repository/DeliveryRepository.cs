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
   public class DeliveryRepository: IDeliveryRepository
    {
        private readonly IdbContext context;
        public DeliveryRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool Delete_Delivary_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Delivary", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Delivary_Package.Delete_Delivary_By_Id", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Delivery> Get_All_Delivary()
        {
            IEnumerable<Delivery> result = context.connection.Query<Delivery>("Delivary_Package.Get_All_Delivary", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Delivery Get_Delivary_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Delivary", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Delivery>("Delivary_Package.Get_Delivary_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public List<Delivery> Get_Delivary_Available(int StatusDelivary)
        {
            IEnumerable<Delivery> result = context.connection.Query<Delivery>("Delivary_Package.Get_All_Delivary", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string Insert_Delivary(Delivery delivery)
        {
            var p = new DynamicParameters();

            p.Add("DelivaryId", delivery.Delivery_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Statua_Delivary", delivery.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Xl", delivery.Xlit, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Yl", delivery.Ylit, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Delivary_Package.Insert_Delivary", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Delivary(Delivery delivery)
        {
            var p = new DynamicParameters();

            p.Add("Id_Of_Delivary", delivery.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("DelivaryId", delivery.Delivery_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Statua_Delivary", delivery.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Xl", delivery.Xlit, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Yl", delivery.Ylit, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Delivary_Package.Update_Delivary", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Update_LxLy(string lx, string ly)
        {
            var p = new DynamicParameters();
            p.Add("lx", lx, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ly", ly, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Delivary_Package.Update_LxLy", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public Delivery Get_LxLy()
        {
            var result = context.connection.Query<Delivery>("Delivary_Package.Get_LxLy", commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();

        }

    }
}
