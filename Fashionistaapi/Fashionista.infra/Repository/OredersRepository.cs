﻿using Dapper;
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
            context.connection.Execute("Orders_Package.Delete_Order", ob, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<OrderAdmin> GetOrder_BetweenDate(SearchDate date)
        {
            var ob = new DynamicParameters();
            ob.Add("StartDate", date.DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
            ob.Add("EndDate", date.DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Package.GetOrder_BetweenDate", ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderU> GetOrder_BetweenDate_User(SearchDateUser date)
        {
            var ob = new DynamicParameters();
            ob.Add("StartDate", date.DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
            ob.Add("EndDate", date.DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
            ob.Add("CUST_ID", date.CUST_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<OrderU> result = context.connection.Query<OrderU>("Orders_Package.GetOrder_BetweenDate_User", ob,  commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        

        public List<OrderU> Get_AllOrder_User(int CUST_ID)
        {
            var ob = new DynamicParameters();
            ob.Add("CUST_ID", CUST_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<OrderU> result = context.connection.Query<OrderU>("Orders_Package.Get_AllOrder_User", ob,commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderAdmin> Get_All_CompletedOrders()
        {
            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Package.Get_All_CompletedOrders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderAdmin> Get_All_NotCompletedOrders()
        {
            IEnumerable<OrderAdmin> result = context.connection.Query<OrderAdmin>("Orders_Package.Get_All_NotCompletedOrders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<DetailsOrder> Get_DetailsOrder(int ID_Order)
        {
            var ob = new DynamicParameters();
            ob.Add("ID_Order", ID_Order, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<DetailsOrder> result = context.connection.Query<DetailsOrder>("Orders_Package.Get_DetailsOrder",ob, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<OrderU> Get_NotCompletedOrders_User(int CUST_ID)
        {

            var ob = new DynamicParameters();
            ob.Add("CUST_ID", CUST_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<OrderU> result = context.connection.Query<OrderU>("Orders_Package.Get_NotCompletedOrders_User", ob,commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Insert_Order(Order order)
        {

            var ob = new DynamicParameters();
            ob.Add("ID_Delivery", order.DeliveryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("Date_Order", order.Dateoforder, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            context.connection.Execute("Orders_Package.Insert_Order", ob, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Update_Order(Order order)
        {
            var ob = new DynamicParameters();
            ob.Add("O_Status", order.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("Id_Order", order.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            context.connection.Execute("Orders_Package.Update_Order", ob, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}