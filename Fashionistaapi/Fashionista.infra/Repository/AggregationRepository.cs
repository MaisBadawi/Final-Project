using Dapper;
using Fashionista.core.Common;
using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fashionista.infra.Repository
{
    public class AggregationRepository : IAggregationRepository
    {
        private readonly IdbContext context;
        public AggregationRepository(IdbContext context)
        {
            this.context = context;
        }
        public int NumEmp()
        {

            Aggregetion result = context.connection.Query("Aggregation_PACKAGE.NumEmp", commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result.NumEmp;
        }

        public int NumOfOrder(User IDOFUSER)
        {
            var p = new DynamicParameters();
            p.Add("IDOFUSER",IDOFUSER.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            Aggregetion result = context.connection.Query("Aggregation_PACKAGE.NumOfOrder", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result.NumOfOrder;
           
        }

        public int NumOrderDev(Order Id_dev)
        {
            var p = new DynamicParameters();
            p.Add("Id_dev", Id_dev.DeliveryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            Aggregetion result = context.connection.Query("Aggregation_PACKAGE.NumOrderDev", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result.NumOrderDev;
        }

        public int NumOrderDevDaily(OrderDev orderDev)
        {
            var p = new DynamicParameters();
            p.Add("Id_dev", orderDev.Id_dev, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("dateday", orderDev.dateday, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            Aggregetion result = context.connection.Query("Aggregation_PACKAGE.NumOrderDevDaily", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result.NumOrderDevDaily;
        }

        public int NumUser()
        {
          

            Aggregetion result = context.connection.Query("Aggregation_PACKAGE.NumUser",  commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result.NumUser;
        }

        public int SumOrders(User IDOFUSER)
        {
            var p = new DynamicParameters();
            p.Add("IDOFUSER",IDOFUSER.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            Aggregetion result = context.connection.Query("Aggregation_PACKAGE.SumOrders", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result.SumOrders;
        }

        public float SumSalary()
        {
       

            Aggregetion result = context.connection.Query("Aggregation_PACKAGE.SumSalary", commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result.SumSalary;
        }

        public float SumSales()
        {
          

            Aggregetion result = context.connection.Query("Aggregation_PACKAGE.SumSales",  commandType: CommandType.StoredProcedure).SingleOrDefault();
            return result.SumSales;
        }
    }
}
