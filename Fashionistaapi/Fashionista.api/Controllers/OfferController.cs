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
    public class OfferController : ControllerBase
    {
        private readonly IOfferService service;
        public OfferController(IOfferService service)
        {
            this.service = service;
        }


        
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Offer([FromBody] Offer offer)
        {
            return service.Insert_Offer(offer);
        }
       
        
        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Offer([FromBody] Offer offere)
        {
            return service.Update_Offer(offere);
        }

      
        
        [HttpGet]
        [ProducesResponseType(typeof(List<Offer>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Offer> GET_All_Offer()
        {
            return service.GET_All_Offer();
        }

       
        
        [HttpGet("GetOfferById/{id}")]
        [ProducesResponseType(typeof(Offer), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Offer Get_Offer_By_Id(int id)
        {
            return service.Get_Offer_By_Id(id);
        }

       
        
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Offer(int id)
        {
            return service.Delete_Offer(id);
        }

    }
}
