using Fashionista.core.Data;
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
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryServices service;
        public DeliveryController(IDeliveryServices service)
        {
            this.service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Delivary([FromBody] Delivery delivery)
        {
            return service.Insert_Delivary(delivery);
        }
      
        
        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Delivary([FromBody] Delivery delivery)
        {
            return service.Update_Delivary(delivery);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Delivery>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Delivery> Get_All_Delivary()
        {
            return service.Get_All_Delivary();
        }




        [HttpGet("GetDeliveryById/{id}")]
        [ProducesResponseType(typeof(Delivery), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Delivery Get_Delivary_By_Id(int id)
        {
            return service.Get_Delivary_By_Id(id);
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Delivary_By_Id(int id)
        {
            return service.Delete_Delivary_By_Id(id);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Delivery>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("Update_LxLy/{lx}/{ly}")]
        public bool Update_LxLy(string lx, string ly)
        {
            return service.Update_LxLy(lx, ly);
        }


        [HttpGet]
        [ProducesResponseType(typeof(Delivery), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("GetLxLy")]
        public Delivery Get_LxLy()
        {
            return service.Get_LxLy();

        }


    }

}

