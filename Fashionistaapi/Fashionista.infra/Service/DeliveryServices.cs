using Fashionista.core.Data;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
   public class DeliveryServices : IDeliveryServices
    {
        private readonly IDeliveryRepository deliveryrepository;
        public DeliveryServices(IDeliveryRepository deliveryrepository)
        {
            this.deliveryrepository = deliveryrepository;
        }
        public bool Delete_Delivary_By_Id(int id)
        {
            return deliveryrepository.Delete_Delivary_By_Id(id);
        }

        public List<Delivery> Get_All_Delivary()
        {
            return deliveryrepository.Get_All_Delivary();
        }

        public List<Delivery> Get_Delivary_Available(int StatusDelivary)
        {
            return deliveryrepository.Get_Delivary_Available(StatusDelivary);
        }

        public Delivery Get_Delivary_By_Id(int id)
        {
            return deliveryrepository.Get_Delivary_By_Id(id);
        }

        public string Insert_Delivary(Delivery delivery)
        {
            return deliveryrepository.Insert_Delivary(delivery);
        }

        public bool Update_Delivary(Delivery delivery)
        {
            return deliveryrepository.Update_Delivary(delivery);
        }

        public bool Update_LxLy(string lx, string ly)
        {
            return deliveryrepository.Update_LxLy(lx, ly);
        }

        public Delivery Get_LxLy()
        {
            return deliveryrepository.Get_LxLy();

        }
    }
}
