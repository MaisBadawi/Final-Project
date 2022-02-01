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
    public class AggregationController : ControllerBase
    {
        private readonly IAggregationService aggregationService;
        public AggregationController(IAggregationService aggregationService)
        {
            this.aggregationService = aggregationService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumEmp")]
        public int NumEmp()
        {
            return aggregationService.NumEmp();
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumOfOrder/{IDOFUSER}")]
        public int NumOfOrder(User IDOFUSER)
        {
            return aggregationService.NumOfOrder(IDOFUSER);
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumOrderDev/{Id_dev}")]
        public int NumOrderDev(Order Id_dev)
        {
            return aggregationService.NumOrderDev(Id_dev);
        }


        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumOrderDevDaily")]
        public int NumOrderDevDaily(OrderDev orderDev)
        {
            return aggregationService.NumOrderDevDaily(orderDev);
        }



        [HttpGet]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumUser")]
        public int NumUser()
        {
            return aggregationService.NumUser();
        }




        [HttpGet]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("SumOrders/{IDOFUSER}")]
        public int SumOrders(User IDOFUSER)
        {
            return aggregationService.SumOrders(IDOFUSER);
        }


        [HttpGet]
        [ProducesResponseType(typeof(float), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("SumSalary")]
        public float SumSalary()
        {
            return aggregationService.SumSalary();
        }


        [HttpGet]
        [ProducesResponseType(typeof(float), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("SumSales")]
        public float SumSales()
        {
            return aggregationService.SumSales();
        }

    }
}
