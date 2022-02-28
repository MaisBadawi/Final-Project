using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
    public interface IBuyingRepository
    {

        public bool Insert_UserOrder(UserOrder userOrder);//before insert userorder used( Procedure GetPrice_PropID) to get the price of a product by id  property


        public List<DetailsOrder> GetProp_CustID(int ID);//Get Items from cart 
        public bool UpdateQuant_ID(UserOrder userOrder);//update quant of prop before payment
        public bool DeleteUO_ID(int Id);//delet item from cart before payment
        public bool Update_OrderID(int CustId, int OrderId);//// store details of order (prop ,qunt,price) in order table after dicount from visa and get orderID 

        public bool Discount_QuantityProp(int Id_Of_Cust );

    }
}
