using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumEmp")]
         public Aggregetion NumEmp()
        {
            return aggregationService.NumEmp();
        }

        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumOfOrder/{IDOFUSER}")]
    public Aggregetion NumOfOrder(int IDOFUSER)
        {
            return aggregationService.NumOfOrder(IDOFUSER);
        }


        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("SumOrders/{IDOFUSER}")]
        public Aggregetion SumOrders(int IDOFUSER)
        {
            return aggregationService.SumOrders(IDOFUSER);
        }



        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumberOfCard/{IDOFUSER}")]
        public Aggregetion NumberOfCard(int IDOFUSER)
        {
            return aggregationService.NumberOfCard(IDOFUSER);
        }

        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("MyMssg/{IDOFUSER}")]
        public Aggregetion MyMssg(int IDOFUSER)
        {
            return aggregationService.MyMssg(IDOFUSER);
        }



        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumOrderDev/{Id_dev}")]
    public Aggregetion NumOrderDev(Order Id_dev)
        {
            return aggregationService.NumOrderDev(Id_dev);
        }


        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumOrderDevDaily")]
    public Aggregetion NumOrderDevDaily(OrderDev orderDev)
        {
            return aggregationService.NumOrderDevDaily(orderDev);
        }



        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumUser")]
        public Aggregetion NumUser()
        {
            return aggregationService.NumUser();
        }

   
        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("SumSalary")]
         public Aggregetion SumSalary()
        {
            return aggregationService.SumSalary();
        }


        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("SumSales")]
        public Aggregetion SumSales()
        {
            return aggregationService.SumSales();
        }


      [HttpGet]
      [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
      [ProducesResponseType(StatusCodes.Status400BadRequest)]
      [Route("SumSalesDaily")]
       public Aggregetion SumSalesDaily()
      {
          return aggregationService.SumSalesDaily();
      }



        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumOrdersDaily")]
        public Aggregetion NumOrdersDaily()
        {
            return aggregationService.NumOrdersDaily();
        }

        [HttpPost]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("SalesMonthly")]
        public Aggregetion SalesMonthly(Aggregetion ag)
        {
            return aggregationService.SalesMonthly(ag);
        }


        [HttpPost]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("SalesYearly")]
        public Aggregetion SalesYearly(Aggregetion ag)
        {
            return aggregationService.SalesYearly(ag);
        }
        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumAllProductCurrently")]
        public Aggregetion NumAllProductCurrently()
        {
            return aggregationService.NumAllProductCurrently();
        }

        [HttpPost]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumProductsSoldBetweenDates")]
        public Aggregetion NumProductsSoldBetweenDates(DateTime DateFrom, DateTime DateTo)
        {
            return aggregationService.NumProductsSoldBetweenDates(DateFrom, DateTo);
        }

        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumProductsSoldDaily")]
        public Aggregetion NumProductsSoldDaily()
        {
            return aggregationService.NumProductsSoldDaily();
        }

        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumProductsSoldMonthly")]
        public Aggregetion NumProductsSoldMonthly()
        {
            return aggregationService.NumProductsSoldMonthly();
        }


        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumProductsSoldYearly")]
        public Aggregetion NumProductsSoldYearly()
        {
            return aggregationService.NumProductsSoldYearly();
        }


        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("NumSMSNew")]
        public Aggregetion NumSMSNew()
        {
            return aggregationService.NumSMSNew();
        }


        [HttpGet]
        [ProducesResponseType(typeof(Aggregetion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("SumSalAfterDed")]
        public Aggregetion SumSalAfterDed()
        {
            return aggregationService.SumSalAfterDed();
        }
    }
}
