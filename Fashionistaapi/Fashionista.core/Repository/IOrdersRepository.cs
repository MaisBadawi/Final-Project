using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
    public interface IOrdersRepository
    {
        public bool Insert_Order(Order order);
        public bool Delete_Order(int Id_Order );
        public bool Update_Order(Order order);
        List<OrderAdmin> Get_All_CompletedOrders();
        List<OrderAdmin> Get_All_NotCompletedOrders();
        List<OrderU> Get_AllOrder_User(int CUST_ID );
        List<OrderU> Get_NotCompletedOrders_User(int CUST_ID  );
        List<OrderAdmin> GetOrder_BetweenDate(SearchDate date);
        List<OrderU> GetOrder_BetweenDate_User(SearchDateUser date);
        List<DetailsOrder> Get_DetailsOrder(int ID_Order  );
    }
}
