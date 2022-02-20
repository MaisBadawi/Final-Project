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
    public class OredersRepository : IOrdersRepository
    {
        private readonly IdbContext context;
        public OredersRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool Delete_Order(int Id_Order)
        {
            var ob = new DynamicParameters();
            ob.Add("Id_Order", Id_Order, dbType: DbType.Int32, direction: ParameterDirection.Input);
            context.connection.Execute("Orders_Pakage.Delete_Order", ob, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<OrderAdmin> GetOrder_BetweenDate(SearchDate date)
        {
            var ob = new DynamicParameters();
            ob.Add("StartDate", date.DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
            ob.Add("EndDate", date.DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Pakage.GetOrder_BetweenDate", ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderU> GetOrder_BetweenDate_User(SearchDateUser date)
        {
            var ob = new DynamicParameters();
            ob.Add("StartDate", date.DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
            ob.Add("EndDate", date.DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
            ob.Add("CUST_ID", date.CUST_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<OrderU> result = context.connection.Query<OrderU>("Orders_Pakage.GetOrder_BetweenDate_User", ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public List<OrderU> Get_AllOrder_User(int CUST_ID)
        {
            var ob = new DynamicParameters();
            ob.Add("CUST_ID", CUST_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<OrderU> result = context.connection.Query<OrderU>("Orders_Pakage.Get_AllOrder_User", ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderAdmin> Get_All_CompletedOrders()
        {
            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Pakage.Get_All_CompletedOrders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderAdmin> Get_All_NotCompletedOrders()
        {
            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Pakage.Get_All_NotCompletedOrders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderAdmin> Get_All_Orders()
        {
            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Pakage.Get_All_Orders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<DetailsOrder> Get_DetailsOrder(int ID_Order)
        {
            var ob = new DynamicParameters();
            ob.Add("ID_Order", ID_Order, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<DetailsOrder> result = context.connection.Query<DetailsOrder>("Orders_Pakage.Get_DetailsOrder", ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderU> Get_NotCompletedOrders_User(int CUST_ID)
        {

            var ob = new DynamicParameters();
            ob.Add("CUST_ID", CUST_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<OrderU> result = context.connection.Query<OrderU>("Orders_Pakage.Get_NotCompletedOrders_User", ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Insert_Order(Order order)
        {

            var ob = new DynamicParameters();
            ob.Add("ID_Delivery", order.DeliveryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("Date_Order", order.Dateoforder, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            ob.Add("LX_U", order.LX, dbType: DbType.String, direction: ParameterDirection.Input);

            ob.Add("LX_Y", order.LY, dbType: DbType.String, direction: ParameterDirection.Input);

            context.connection.Execute("Orders_Pakage.Insert_Order", ob, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Update_Order(Order order)
        {
            var ob = new DynamicParameters();
            ob.Add("O_Status", order.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("Id_Order", order.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("LX_U", order.LX, dbType: DbType.String, direction: ParameterDirection.Input);

            ob.Add("LX_Y", order.LY, dbType: DbType.String, direction: ParameterDirection.Input);
            context.connection.Execute("Orders_Pakage.Update_Order", ob, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<OrderAdmin> Get_Daily_Orders(DateTime numOfDay)
        {


            var ob = new DynamicParameters();
            ob.Add("O_Today", numOfDay, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Pakage.Get_Daily_Orders", ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public List<OrderAdmin> Get_Monthly_Orders(int numOfMonth)
        {
            var ob = new DynamicParameters();
            ob.Add("O_month", numOfMonth, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Pakage.Get_Month_Orders", ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderAdmin> Get_Yearly_Orders(int numOfYear)
        {
            var ob = new DynamicParameters();
            ob.Add("O_year", numOfYear, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Pakage.Get_annual_Orders", ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }



    }
}
