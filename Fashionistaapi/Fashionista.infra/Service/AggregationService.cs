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

        public int NumEmp()
        {
            return aggregationRepository.NumEmp();
        }

        public int NumOfOrder(User IDOFUSER)
        {
            return aggregationRepository.NumOfOrder(IDOFUSER);
        }

        public int NumOrderDev(Order Id_dev)
        {
            return aggregationRepository.NumOrderDev(Id_dev);
        }

        public int NumOrderDevDaily(OrderDev orderDev)
        {
            return aggregationRepository.NumOrderDevDaily(orderDev);
        }

        public int NumUser()
        {
            return aggregationRepository.NumUser();
        }

        public int SumOrders(User IDOFUSER)
        {
            return aggregationRepository.SumOrders(IDOFUSER);
        }

        public float SumSalary()
        {
            return aggregationRepository.SumSalary();
        }

        public float SumSales()
        {
            return aggregationRepository.SumSales();
        }
    }
}
