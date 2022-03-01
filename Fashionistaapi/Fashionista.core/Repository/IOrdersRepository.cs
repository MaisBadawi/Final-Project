using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
    public interface IOrdersRepository
    {
        public Order Insert_Order(string lx, string ly);
        public bool Delete_Order(int Id_Order );
        public bool Update_Order(int Id_Order, int O_Status);
        public List<OrderAdmin> Get_All_CompletedOrders();
        public List<OrderAdmin> Get_All_NotCompletedOrders();
        public List<OrderU> Get_AllOrder_User(int CUST_ID );
        public List<OrderU> Get_NotCompletedOrders_User(int CUST_ID  );
        public List<OrderAdmin> GetOrder_BetweenDate(SearchDate date);
        public List<OrderU> GetOrder_BetweenDate_User(SearchDateUser date);
        public List<DetailsOrder> Get_DetailsOrder(int ID_Order  );

        public List<OrderAdmin> Get_All_Orders();

        public List<OrderAdmin> Get_Daily_Orders(DateTime numOfDay);

        public List<OrderAdmin> Get_Monthly_Orders(int numOfMonth);

        public List<OrderAdmin> Get_Yearly_Orders(int numOfYear);

    }
}
