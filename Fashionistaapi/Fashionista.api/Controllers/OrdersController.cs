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
        [HttpDelete]
        [Route("DeleteOrder/{Id}")]
        public bool Delete_Order(int Id_Order)
        {
            return orderService.Delete_Order(Id_Order);
        }

        [HttpPost]
        [Route("DisplayOrderBetweenDateAdmin")]
        public List<OrderAdmin> GetOrder_BetweenDate([FromBody]SearchDate date)
        {
            return orderService.GetOrder_BetweenDate(date);
        }
        [HttpPost]
        [Route("DisplayOrderBetweenDateUser")]
        public List<OrderU> GetOrder_BetweenDate_User([FromBody]SearchDateUser date)
        {
            return orderService.GetOrder_BetweenDate_User(date);
        }


        [HttpGet]
        [Route("DisplayOrderUser/{CUST_ID}")]
        public List<OrderU> Get_AllOrder_User(int CUST_ID)
        {
            return orderService.Get_AllOrder_User(CUST_ID);
        }


        [HttpGet]
        [Route("DisplayOrderCompletedAdmin")]
        public List<OrderAdmin> Get_All_CompletedOrders()
        {
            return orderService.Get_All_CompletedOrders();
        }

        [HttpGet]
        [Route("DisplayOrderNCompletedAdmin")]

        public List<OrderAdmin> Get_All_NotCompletedOrders()
        {
            return orderService.Get_All_NotCompletedOrders();
        }

        [HttpGet]
        [Route("DisplayDetailsOrder/{ID_Order}")]

        public List<DetailsOrder> Get_DetailsOrder(int ID_Order)
        {
            return orderService.Get_DetailsOrder(ID_Order);
        }

        [HttpGet]
        [Route("DisplayOrderNCompletedUser/{CUST_ID}")]

        public List<OrderU> Get_NotCompletedOrders_User(int CUST_ID)
        {
            return orderService.Get_NotCompletedOrders_User(CUST_ID);
        }

        [HttpPost]
        [Route("AddOrder")]

        public bool Insert_Order([FromBody] Order order)
        {
            return orderService.Insert_Order(order);
        }


        [HttpPut]
        [Route("EditOrder")]
        public bool Update_Order([FromBody]Order order)
        {
            return orderService.Update_Order(order);
        }

    }
}
