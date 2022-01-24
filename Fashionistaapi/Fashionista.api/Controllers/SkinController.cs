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
        public string insert_Skin([FromBody] Skin skin)
        {
            return service.insert_Skin(skin);
        }
        [HttpPut]
        public bool update_Skin([FromBody] Skin skin)
        {
            return service.update_Skin(skin);
        }

        [HttpGet]
        public List<Skin> getall_Skin()
        {
            return service.getall_Skin();
        }


        [HttpGet("GetSkinById/{id}")]
        public Skin get_Skin_By_id(int id)
        {
            return service.get_Skin_By_id(id);
        }


        [HttpDelete]
        public bool delete_Skin(int id)
        {
            return service.delete_Skin(id);
        }
    }
}
