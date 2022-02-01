using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
    public interface IAggregationRepository
    {
        public int NumOfOrder(User IDOFUSER );
        public int SumOrders(User IDOFUSER );
        public int NumEmp();
        public int NumUser();
        public float SumSalary();
        public float SumSales();
        public int NumOrderDev(Order Id_dev );
        public int NumOrderDevDaily(OrderDev orderDev);
    }
}
