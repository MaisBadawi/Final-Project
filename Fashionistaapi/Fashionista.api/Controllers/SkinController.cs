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
    public class SkinController : ControllerBase
    {
        private readonly ISkinServices service;
        public SkinController(ISkinServices service)
        {
            this.service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string insert_Skin([FromBody] Skin skin)
        {
            return service.insert_Skin(skin);
        }
        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool update_Skin([FromBody] Skin skin)
        {
            return service.update_Skin(skin);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Skin>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Skin> getall_Skin()
        {
            return service.getall_Skin();
        }


        [HttpGet("GetSkinById/{id}")]
        [ProducesResponseType(typeof(Skin), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Skin get_Skin_By_id(int id)
        {
            return service.get_Skin_By_id(id);
        }


        [HttpDelete]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool delete_Skin(int id)
        {
            return service.delete_Skin(id);
        }
    }
}
