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
    public class AgeController : ControllerBase
    {
        private readonly IAgeServices service;
        public AgeController(IAgeServices service)
        {
            this.service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Age([FromBody] Age age)
        {
            return service.Insert_Age(age);
        }
        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Age([FromBody] Age age)
        {
            return service.Update_Age(age);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Age>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Age> GET_All_Age()
        {
            return service.GET_All_Age();
        }

        [HttpGet("GetAgeById/{id}")]
        [ProducesResponseType(typeof(Age), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Age Get_Age_By_Id(int id)
        {
            return service.Get_Age_By_Id(id);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Age(int id)
        {
            return service.Delete_Age(id);
        }

    }
}
