using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
    public interface IAggregationRepository
    {

        public Aggregetion NumOfOrder(int IDOFUSER );
        public Aggregetion SumOrders(int IDOFUSER );
        public Aggregetion NumberOfCard(int IDOFUSER);
        public Aggregetion MyMssg(int IDOFUSER);

        public Aggregetion NumEmp();
    public Aggregetion NumUser();
    public Aggregetion SumSalary();
    public Aggregetion SumSalesDaily(Aggregetion aggregetion);
    public Aggregetion SumSales();
    public Aggregetion NumOrderDev(Order Id_dev );
    public Aggregetion NumOrderDevDaily(OrderDev orderDev);
    }
}
