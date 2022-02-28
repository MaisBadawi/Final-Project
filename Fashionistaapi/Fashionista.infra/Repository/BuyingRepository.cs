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
    public class BuyingRepository : IBuyingRepository

    {
        private readonly IdbContext context;
        public BuyingRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool DeleteUO_ID(int Id)
        {
            var ob = new DynamicParameters();
            ob.Add("Id_Of_UO", Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            context.connection.Execute("Buying_package.DeleteUO_ID", ob, commandType: CommandType.StoredProcedure);
            
            return true;
        }

        public bool Discount_QuantityProp(int Id_Of_Cust)
        {

            var ob = new DynamicParameters();
            ob.Add("Id_Of_Cust", Id_Of_Cust, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<UserOrder> result = context.connection.Query<UserOrder>("Buying_package.Get_Quantity", ob, commandType: CommandType.StoredProcedure);
            result.ToList();

            foreach (var i in result)
            {
                var p = new DynamicParameters();
                p.Add("Id_Of_pro", i.Pro_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
                p.Add("Qunt", i.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);

                context.connection.Execute("Buying_package.Update_Qun_AfterBuying", p, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        public List<DetailsOrder> GetProp_CustID(int ID)
        {
            var ob = new DynamicParameters();
            ob.Add("Id_Of_Cust", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<DetailsOrder> result = context.connection.Query<DetailsOrder>("Buying_package.GetProp_CustID", ob,commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool Insert_UserOrder(UserOrder userOrder)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_pro",userOrder.Pro_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);//

            IEnumerable<Product> result = context.connection.Query<Product>("Buying_package.GetPrice_PropID", p, commandType: CommandType.StoredProcedure);
            Product item = result.FirstOrDefault();

            var ob = new DynamicParameters();
            ob.Add("Id_Of_Order", null, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("Id_Of_Cust", userOrder.CustId, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            ob.Add("Id_Of_pro", userOrder.Pro_Id, DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("Qunt", userOrder.Quantity, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            ob.Add("O_Price", userOrder.Quantity * item.Price, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            context.connection.Execute("Buying_package.Insert_User_Order", ob, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateQuant_ID(UserOrder userOrder)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_pro", userOrder.Pro_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Product> result = context.connection.Query<Product>("Buying_package.GetPrice_PropID", p, commandType: CommandType.StoredProcedure);
            Product item = result.SingleOrDefault();

            var ob = new DynamicParameters();
            ob.Add("Id_Of_UO", userOrder.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("Qunt", userOrder.Quantity, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            ob.Add("O_Price", userOrder.Quantity*item.Price, DbType.Decimal, direction: ParameterDirection.Input);
            context.connection.Execute("Buying_package.UpdateQuant_ID", ob, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Update_OrderID(int CustId, int OrderId)
        {
            var ob = new DynamicParameters();
            ob.Add("Id_Of_Cust", CustId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("Id_Order", OrderId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            context.connection.Execute("Buying_package.Update_OrderID", ob, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
