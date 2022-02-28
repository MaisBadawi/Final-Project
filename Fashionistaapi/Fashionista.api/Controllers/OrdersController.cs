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
    public class OrdersController : ControllerBase
    {

        private readonly IOrderService orderService;
        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }



        [HttpDelete]
        [Route("DeleteOrder/{Id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Order(int Id_Order)
        {
            return orderService.Delete_Order(Id_Order);
        }



        [HttpPost]
        [Route("DisplayOrderBetweenDateAdmin")]
        [ProducesResponseType(typeof(List<OrderAdmin>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<OrderAdmin> GetOrder_BetweenDate([FromBody] SearchDate date)
        {
            return orderService.GetOrder_BetweenDate(date);
        }



        [HttpPost]
        [Route("DisplayOrderBetweenDateUser")]
        [ProducesResponseType(typeof(List<OrderU>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<OrderU> GetOrder_BetweenDate_User([FromBody] SearchDateUser date)
        {
            return orderService.GetOrder_BetweenDate_User(date);
        }



        [HttpGet]
        [Route("DisplayOrderUser/{CUST_ID}")]
        [ProducesResponseType(typeof(List<OrderU>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<OrderU> Get_AllOrder_User(int CUST_ID)
        {
            return orderService.Get_AllOrder_User(CUST_ID);
        }


        [HttpGet]
        [Route("DisplayOrderCompletedAdmin")]
        [ProducesResponseType(typeof(List<OrderAdmin>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<OrderAdmin> Get_All_CompletedOrders()
        {
            return orderService.Get_All_CompletedOrders();
        }



        [HttpGet]
        [Route("DisplayOrderNCompletedAdmin")]
        [ProducesResponseType(typeof(List<OrderAdmin>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<OrderAdmin> Get_All_NotCompletedOrders()
        {
            return orderService.Get_All_NotCompletedOrders();
        }



        [HttpGet]
        [Route("DisplayDetailsOrder/{ID_Order}")]
        [ProducesResponseType(typeof(List<DetailsOrder>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<DetailsOrder> Get_DetailsOrder(int ID_Order)
        {
            return orderService.Get_DetailsOrder(ID_Order);
        }



        [HttpGet]
        [Route("DisplayOrderNCompletedUser/{CUST_ID}")]
        [ProducesResponseType(typeof(List<OrderU>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<OrderU> Get_NotCompletedOrders_User(int CUST_ID)
        {
            return orderService.Get_NotCompletedOrders_User(CUST_ID);
        }



        [HttpGet]
        [Route("AddOrder/{lx}/{ly}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Order Insert_Order(string lx, string ly)
        {
            return orderService.Insert_Order(lx, ly);
        }



        [HttpPut]
        [Route("EditOrder")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Order([FromBody] Order order)
        {
            return orderService.Update_Order(order);
        }



        [HttpGet]
        [Route("GetAllOrders")]
        [ProducesResponseType(typeof(List<OrderAdmin>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<OrderAdmin> Get_All_Orders()
        {
            return orderService.Get_All_Orders();
        }

        [HttpGet]
        [Route("GetDialyOrders/{numOfDay}")]
        [ProducesResponseType(typeof(List<OrderAdmin>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<OrderAdmin> Get_Daily_Orders(DateTime numOfDay)
        {
            return orderService.Get_Daily_Orders(numOfDay);
        }


        [HttpGet]
        [Route("GetMonthlyOrders/{numOfMonth}")]
        [ProducesResponseType(typeof(List<OrderAdmin>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<OrderAdmin> Get_Monthly_Orders(int numOfMonth)
        {
            return orderService.Get_Monthly_Orders(numOfMonth);
        }

        [HttpGet]
        [Route("GetAnnualyOrders/{numOfYear}")]
        [ProducesResponseType(typeof(List<OrderAdmin>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public List<OrderAdmin> Get_Annual_Orders(int numOfYear)
        {
            return orderService.Get_Yearly_Orders(numOfYear);
        }
    }
}