using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;

using System.Text;

namespace Fashionista.infra.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository paymentrepository;

        public PaymentService(IPaymentRepository paymentrepository)
        {
            this.paymentrepository = paymentrepository;
        }

        public bool Delete_Visa_By_Id(int id)
        {
            return paymentrepository.Delete_Visa_By_Id(id);
        }

        public bool Discount_Order(int userId, decimal orderPrice)
        {
            return paymentrepository.Discount_Order(userId,orderPrice);        }

        public List<Payment> Get_All_Visa()
        {
            return paymentrepository.Get_All_Visa();
        }

        public decimal Get_Balance(int userId)
        {
            return paymentrepository.Get_Balance(userId);
        }

        public Payment Get_Visa_By_Id(int id)
        {
            return paymentrepository.Get_Visa_By_Id(id);
        }

    public Payment Get_Visa_By_UserId(int User_Id)
    {
      return paymentrepository.Get_Visa_By_UserId(User_Id);
    }

    public string Insert_Visa(Payment payment)
        {
            return paymentrepository.Insert_Visa(payment);        }

        public BalanceDto SUM_Max_Balance()
        {
            return paymentrepository.SUM_Max_Balance();        }

    public bool UpdateBalance(UpdateBalance updateBalance)
    {
      return paymentrepository.UpdateBalance(updateBalance);
    }

    public UpdateCode Update_Code(int userId)
    {
      UpdateCode result = paymentrepository.Update_Code(userId);
    
        MimeMessage message = new MimeMessage();
        MailboxAddress from = new MailboxAddress("Fashinista", "Khr25984@gmail.com");
        message.From.Add(from);
        MailboxAddress to = new MailboxAddress("Customer", result.EmailU);
        message.To.Add(to);
        message.Subject = "Password Code";
        BodyBuilder bodyBuilder = new BodyBuilder();
        bodyBuilder.HtmlBody = "<h1>Update Balance</h1><p>Use This Code To Update Your Visa Balance <strong>" + result.Code + "</strong></P>";
        message.Body = bodyBuilder.ToMessageBody();

        using (var item = new SmtpClient())
        {
          item.Connect("smtp.gmail.com", 587, false);
          item.Authenticate("Khr25984@gmail.com", "RAMAM97@97");
          item.Send(message);
          item.Disconnect(true);
        }

        return result;
      
     
    }

    public bool Update_Visa_By_Id(Payment payment)
        {
            return paymentrepository.Update_Visa_By_Id(payment);   
        }
    }
}
