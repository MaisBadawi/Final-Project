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
    public class StandaredSizeController : ControllerBase
    {
        private readonly IStandaredSizeService service;
        public StandaredSizeController(IStandaredSizeService service)
        {
            this.service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Size([FromBody] StandaredSize size)
        {
            return service.Insert_Size(size);
        }
        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Size([FromBody] StandaredSize size)
        {
            return service.Update_Size(size);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<StandaredSize>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<StandaredSize> GET_All_StandaredSize()
        {
            return service.GET_All_Size();
        }

        [HttpGet("GetSizeById/{id}")]
        [ProducesResponseType(typeof(StandaredSize), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public StandaredSize Get_Size_By_Id(int id)
        {
            return service.Get_Size_By_Id(id);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Size(int id)
        {
            return service.Delete_Size(id);
        }


    }
}
