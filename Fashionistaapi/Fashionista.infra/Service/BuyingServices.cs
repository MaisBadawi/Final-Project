using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class BuyingServices : IBuyingServices
    {
        private readonly IBuyingRepository buyingRepository;
        public BuyingServices(IBuyingRepository _buyingRepository)
        {
            this.buyingRepository = _buyingRepository;
        }
        

        public bool DeleteUO_ID(int Id)
        {

            return buyingRepository.DeleteUO_ID(Id);
        }

        public bool Discount_QuantityProp(int Id_Of_Cust)
        {
            return buyingRepository.Discount_QuantityProp(Id_Of_Cust);
        }

        public List<DetailsOrder> GetProp_CustID(int ID)
        {
            return buyingRepository.GetProp_CustID(ID);
        }

        public bool Insert_UserOrder(UserOrder userOrder)
        {
            return buyingRepository.Insert_UserOrder(userOrder);
        }

        public bool UpdateQuant_ID(UserOrder userOrder)
        {
            return buyingRepository.UpdateQuant_ID(userOrder);
        }

        public bool Update_OrderID(int CustId, int OrderId)
        {
            return buyingRepository.Update_OrderID(CustId, OrderId);
        }
    }
}
