using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
   public interface IPaymentService
    {
        public string Insert_Visa(Payment payment);
        public bool Delete_Visa_By_Id(int id);
        public bool Update_Visa_By_Id(Payment payment);
        public List<Payment> Get_All_Visa();
        public Payment Get_Visa_By_Id(int id);
       
        public bool Discount_Order(int userId, decimal orderPrice);
        public Payment Get_Balance(int userId);
        public BalanceDto SUM_Max_Balance();
       public Payment Get_Visa_By_UserId(int User_Id);
        public UpdateCode Update_Code(int userId);
    public bool UpdateBalance(UpdateBalance updateBalance);


  }
}
