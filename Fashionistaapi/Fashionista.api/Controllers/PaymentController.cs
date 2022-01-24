using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashionista.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }
       
        [HttpPost]
        [Route ("NewVisa")]
        public string Insert_Visa([FromBody] Payment payment)
        { return paymentService.Insert_Visa(payment); }

        [HttpDelete]
        [Route("DeleteVisa/{id}")]
        public bool Delete_Visa_By_Id(int id)
        { return paymentService.Delete_Visa_By_Id(id); }

        [HttpPut]
        [Route("UpdateVisa")]
        public bool Update_Visa_By_Id([FromBody] Payment payment)
        { return paymentService.Update_Visa_By_Id(payment); }


        [HttpGet]
        [Route("AllVisa")]
        public List<Payment> Get_All_Visa()
        { return paymentService.Get_All_Visa(); }



        [HttpGet]
        [Route("GetVisaById/{id}")]
        public Payment Get_Visa_By_Id(int id)
        { return paymentService.Get_Visa_By_Id(id); }


        [HttpPut]
        [Route("UpdateBalance/{visaId}/{visaBalance}")]
        public bool Update_Balance(int visaId, float visaBalance)
        { return paymentService.Update_Balance(visaId, visaBalance); }

        [HttpPut]
        [Route("DiscountOrder/{userId}/{orderPrice}")]
        public bool Discount_Order(int userId, decimal orderPrice)
        { return paymentService.Discount_Order(userId, orderPrice); }


        [HttpGet]
        [Route("GetBalance/{userId}")]
        public decimal Get_Balance(int userId)
        { return paymentService.Get_Balance(userId); }

        [HttpGet]
        [Route("GetSum&MaxBalance")]
        public BalanceDto SUM_Max_Balance()
        { return paymentService.SUM_Max_Balance(); }


    }
}
