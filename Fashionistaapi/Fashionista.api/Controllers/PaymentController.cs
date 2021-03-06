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
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Visa([FromBody] Payment payment)
        { return paymentService.Insert_Visa(payment); }

        [HttpDelete]
        [Route("DeleteVisa/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Visa_By_Id(int id)
        { return paymentService.Delete_Visa_By_Id(id); }

        
        
        [HttpPut]
        [Route("UpdateVisa")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Visa_By_Id([FromBody] Payment payment)
        { return paymentService.Update_Visa_By_Id(payment); }


        [HttpGet]
        [Route("AllVisa")]
        [ProducesResponseType(typeof(List<Payment>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Payment> Get_All_Visa()
        { return paymentService.Get_All_Visa(); }



        [HttpGet]
        [Route("GetVisaById/{id}")]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Payment Get_Visa_By_Id(int id)
        { return paymentService.Get_Visa_By_Id(id); }

      

        [HttpGet]
        [Route("DiscountOrder/{userId}/{orderPrice}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Discount_Order(int userId, decimal orderPrice)
        { return paymentService.Discount_Order(userId, orderPrice); }


        [HttpGet]
        [Route("GetBalance/{id}")]
        [ProducesResponseType(typeof(Payment), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Payment Get_Balance(int id)
        { return paymentService.Get_Balance(id); }

        
        [HttpGet]
        [Route("GetSum&MaxBalance")]
        [ProducesResponseType(typeof(BalanceDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public BalanceDto SUM_Max_Balance()
        { return paymentService.SUM_Max_Balance();

        }


    [HttpGet]
    [Route("GetVisaByUserID/{User_Id}")]
    [ProducesResponseType(typeof(Payment), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public Payment Get_Visa_By_UserId(int User_Id)
    {
      return paymentService.Get_Visa_By_UserId(User_Id);
    }

    [HttpGet]
    [Route("UpdateeCode/{userId}")]
    [ProducesResponseType(typeof(UpdateCode), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public UpdateCode Update_Code(int userId)
    {
      return paymentService.Update_Code(userId);
    }



    [HttpPost]
    [Route("UpdateBalance")]

    [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public bool UpdateBalance(UpdateBalance updateBalance)
    {
      return paymentService.UpdateBalance(updateBalance);
    }

  }
}
