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
    public class BuyingController : ControllerBase
    {

        private readonly IBuyingServices buyingServices;
        public BuyingController(IBuyingServices _buyingServices)
        {
            this.buyingServices = _buyingServices;
        }


        [HttpDelete]
        [Route("DeleteUserOrder/{Id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteUO_ID(int Id)
        {

            return buyingServices.DeleteUO_ID(Id);
        }


        [HttpGet]
        [Route("GetItemCart/{ID}")]
        [ProducesResponseType(typeof(List<DetailsOrder>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<DetailsOrder> GetProp_CustID(int ID)
        {
            return buyingServices.GetProp_CustID(ID);
        }


        [HttpPost]
        [Route("InsertItemToCart")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Insert_UserOrder([FromBody] UserOrder userOrder)
        {
            return buyingServices.Insert_UserOrder(userOrder);
        }



        [HttpPut]
        [Route("EditeItemInCart")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateQuant_ID([FromBody] UserOrder userOrder)
        {
            return buyingServices.UpdateQuant_ID(userOrder);
        }



        [HttpPut]
        [Route("ConfirmationOrder")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_OrderID([FromBody]UserOrder userOrder)
        {
            return buyingServices.Update_OrderID(userOrder);
        }

        [HttpGet]
        [Route("DiscountQuant/{Id_Of_Cust}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Discount_QuantityProp(int Id_Of_Cust)
        {
            return buyingServices.Discount_QuantityProp(Id_Of_Cust);
        }

    }
}
