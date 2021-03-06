using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class AggregationService : IAggregationService
    {

        private readonly IAggregationRepository aggregationRepository;
        public AggregationService(IAggregationRepository aggregationRepository)
        {
            this.aggregationRepository = aggregationRepository;
        }

        public Aggregetion MyMssg(int IDOFUSER)
        {
            return aggregationRepository.MyMssg(IDOFUSER);
        }

        public Aggregetion NumberOfCard(int IDOFUSER)
        {
            return aggregationRepository.NumberOfCard(IDOFUSER);
        }

        public Aggregetion NumEmp()
        {
            return aggregationRepository.NumEmp();
        }

    public Aggregetion NumOfOrder(int IDOFUSER)
        {
            return aggregationRepository.NumOfOrder(IDOFUSER);
        }

    public Aggregetion NumOrderDev(Order Id_dev)
        {
            return aggregationRepository.NumOrderDev(Id_dev);
        }

    public Aggregetion NumOrderDevDaily(OrderDev orderDev)
        {
            return aggregationRepository.NumOrderDevDaily(orderDev);
        }

    public Aggregetion NumUser()
        {
            return aggregationRepository.NumUser();
        }

    public Aggregetion SumOrders(int IDOFUSER)
        {
            return aggregationRepository.SumOrders(IDOFUSER);
        }

    public Aggregetion SumSalary()
        {
            return aggregationRepository.SumSalary();
        }

    public Aggregetion SumSales()
        {
            return aggregationRepository.SumSales();
        }

    public Aggregetion SumSalesDaily()
    {
      return aggregationRepository.SumSalesDaily(); 
    }

        public Aggregetion NumSMSNew()
        {
            return aggregationRepository.NumSMSNew();
        }

        public Aggregetion SumSalAfterDed()
        {
            return aggregationRepository.SumSalAfterDed();
        }
        public Aggregetion SalesMonthly(Aggregetion ag)
        {
            return aggregationRepository.SalesMonthly(ag);
        }

        public Aggregetion SalesYearly(Aggregetion ag)
        {
            return aggregationRepository.SalesYearly(ag);
        }

        public Aggregetion NumOrdersDaily()
        {
            return aggregationRepository.NumOrdersDaily();
        }

        public Aggregetion NumAllProductCurrently()
        {
            return aggregationRepository.NumAllProductCurrently();
        }

        public Aggregetion NumProductsSoldBetweenDates(DateTime DateFrom, DateTime DateTo)
        {
            return aggregationRepository.NumProductsSoldBetweenDates(DateFrom, DateTo);
        }

        public Aggregetion NumProductsSoldDaily()
        {
            return aggregationRepository.NumProductsSoldDaily();
        }

        public Aggregetion NumProductsSoldMonthly()
        {
            return aggregationRepository.NumProductsSoldMonthly();
        }

        public Aggregetion NumProductsSoldYearly()
        {
            return aggregationRepository.NumProductsSoldYearly();
        }


        public Aggregetion NumOrdersYearlyComp()
        {
            return aggregationRepository.NumOrdersYearlyComp();
        }

        public Aggregetion NumOrdersMonthlyComp()
        {
            return aggregationRepository.NumOrdersMonthlyComp();
        }

        public Aggregetion NumOrdersDailyComp()
        {
            return aggregationRepository.NumOrdersDailyComp();
        }


        public float SumSalary2()
        {
            return aggregationRepository.SumSalary2();
        }

        public float SumSales2()
        {
            return aggregationRepository.SumSales2();
        }

      
        public int NumUser2()
        {
            return aggregationRepository.NumUser2();
        }
        public int NumEmp2()
        {
            return aggregationRepository.NumEmp2();
        }
    }
}
