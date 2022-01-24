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
    public class FroleController : ControllerBase
    {
        private readonly IFroleServices service;
        public FroleController(IFroleServices service)
        {
            this.service = service;
        }

        [HttpPost]
        public string Insert_Role([FromBody] Frole role)
        {
            return service.Insert_Role(role);
        }
        [HttpPut]
        public bool Update_Role([FromBody] Frole role)
        {
            return service.Update_Role(role);
        }

        [HttpGet]
        public List<Frole> Get_All_Rolle()
        {
            return service.Get_All_Rolle();
        }


        [HttpGet("GetRoleById/{id}")]
        public Frole Get_Rolle_By_Id(int id)
        {
            return service.Get_Rolle_By_Id(id);
        }


        [HttpDelete("{id}")]
        public bool Delete_Role(int id)
        {
            return service.Delete_Role(id);
        }
    }
}
