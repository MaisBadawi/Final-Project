using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
 public interface IDeliveryRepository
    {
        public string Insert_Delivary(Delivery delivery);
        public bool Delete_Delivary_By_Id(int id);
        public bool Update_Delivary(Delivery delivery);
        public List<Delivery> Get_All_Delivary();
        public Delivery Get_Delivary_By_Id(int id);

        public List<Delivery> Get_Delivary_Available(int StatusDelivary);
    }
}
