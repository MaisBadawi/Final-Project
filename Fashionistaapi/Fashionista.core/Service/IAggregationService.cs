using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
    public interface IAggregationService
    {
    public Aggregetion NumOfOrder(User IDOFUSER);
    public Aggregetion SumOrders(User IDOFUSER);
    public Aggregetion NumEmp();
        public Aggregetion NumUser();
    public Aggregetion SumSalary();
    public Aggregetion SumSales();
    public Aggregetion NumOrderDev(Order Id_dev);
    public Aggregetion SumSalesDaily(Aggregetion aggregetion);

    public Aggregetion NumOrderDevDaily(OrderDev orderDev);
    }
}
