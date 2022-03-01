using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrdersRepository ordersRepository;
        public OrderService(IOrdersRepository ordersRepository)
        {
            this.ordersRepository= ordersRepository;
        }
        public bool Delete_Order(int Id_Order)
        {
            return ordersRepository.Delete_Order(Id_Order);
        }

        public List<OrderAdmin> GetOrder_BetweenDate(SearchDate date)
        {
            return ordersRepository.GetOrder_BetweenDate(date);
        }

        public List<OrderU> GetOrder_BetweenDate_User(SearchDateUser date)
        {
            return ordersRepository.GetOrder_BetweenDate_User(date);
        }

        public List<OrderU> Get_AllOrder_User(int CUST_ID)
        {
            return ordersRepository.Get_AllOrder_User(CUST_ID);
        }

        public List<OrderAdmin> Get_All_CompletedOrders()
        {
            return ordersRepository.Get_All_CompletedOrders();
        }

        public List<OrderAdmin> Get_All_NotCompletedOrders()
        {
            return ordersRepository.Get_All_NotCompletedOrders();
        }

        public List<DetailsOrder> Get_DetailsOrder(int ID_Order)
        {
            return ordersRepository.Get_DetailsOrder(ID_Order);
        }

        public List<OrderU> Get_NotCompletedOrders_User(int CUST_ID)
        {
            return ordersRepository.Get_NotCompletedOrders_User(CUST_ID);
        }

        public Order Insert_Order(string lx, string ly)
        {
            return ordersRepository.Insert_Order(lx, ly);
        }

        public bool Update_Order(int Id_Order, int O_Status)
        {
            return ordersRepository.Update_Order(Id_Order, O_Status);
        }


        public  List<OrderAdmin> Get_All_Orders()
        {
            return ordersRepository.Get_All_Orders();
        }

        public List<OrderAdmin> Get_Daily_Orders(DateTime numOfDay)
        {
            return ordersRepository.Get_Daily_Orders(numOfDay);
        }

        public List<OrderAdmin> Get_Monthly_Orders(int numOfMonth)
        {
            return ordersRepository.Get_Monthly_Orders(numOfMonth);
        }

        public List<OrderAdmin> Get_Yearly_Orders(int numOfYear)
        {
            return ordersRepository.Get_Yearly_Orders(numOfYear);
        }
    }
}
