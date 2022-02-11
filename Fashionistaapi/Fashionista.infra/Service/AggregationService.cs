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

    public Aggregetion SumSalesDaily(Aggregetion aggregetion)
    {
      return aggregationRepository.SumSalesDaily(aggregetion); 
    }
  }
}
