using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository paymentService;

        public PaymentService(IPaymentRepository paymentService)
        {
            this.paymentService = paymentService;
        }

        public bool Delete_Visa_By_Id(int id)
        {
            return paymentService.Delete_Visa_By_Id(id);
        }

        public bool Discount_Order(int userId, decimal orderPrice)
        {
            return paymentService.Discount_Order(userId,orderPrice);        }

        public List<Payment> Get_All_Visa()
        {
            return paymentService.Get_All_Visa();
        }

        public decimal Get_Balance(int userId)
        {
            return paymentService.Get_Balance(userId);
        }

        public Payment Get_Visa_By_Id(int id)
        {
            return paymentService.Get_Visa_By_Id(id);
        }

        public string Insert_Visa(Payment payment)
        {
            return paymentService.Insert_Visa(payment);        }

        public BalanceDto SUM_Max_Balance()
        {
            return paymentService.SUM_Max_Balance();        }

        

        public bool Update_Visa_By_Id(Payment payment)
        {
            return paymentService.Update_Visa_By_Id(payment);   
        }
    }
}
