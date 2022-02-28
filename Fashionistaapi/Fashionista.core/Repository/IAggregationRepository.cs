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
    public Aggregetion SumSalesDaily();
    public Aggregetion SumSales();
    public Aggregetion NumOrderDev(Order Id_dev );
    public Aggregetion NumOrderDevDaily(OrderDev orderDev);

        public Aggregetion SalesMonthly(Aggregetion ag);
        public Aggregetion SalesYearly(Aggregetion ag);
        public Aggregetion NumOrdersDaily();

        public Aggregetion NumAllProductCurrently();
        public Aggregetion NumProductsSoldDaily();
        public Aggregetion NumProductsSoldMonthly();
        public Aggregetion NumProductsSoldYearly();

        public Aggregetion NumProductsSoldBetweenDates(DateTime DateFrom, DateTime DateTo);

        public Aggregetion NumSMSNew();
        public Aggregetion SumSalAfterDed();

        public Aggregetion NumOrdersYearlyComp();

        public Aggregetion NumOrdersMonthlyComp();
        public Aggregetion NumOrdersDailyComp();

    }
}
