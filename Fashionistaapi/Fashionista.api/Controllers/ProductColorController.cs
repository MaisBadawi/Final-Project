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
    public class ProductColorController : ControllerBase
    {
        private readonly IProductColorService service;
        public ProductColorController(IProductColorService service)
        {
            this.service = service;
        }

       
        
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Color([FromBody] ProductColor color)
        {
            return service.Insert_Color(color);
        }
        
       
        
        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Color([FromBody] ProductColor color)
        {
            return service.update_Color(color);
        }

      
        
        [HttpGet]
        [ProducesResponseType(typeof(List<ProductColor>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ProductColor> GET_All_Color()
        {
            return service.Getall_Color();
        }

       
        
        [HttpGet("GetColorById/{id}")]
        [ProducesResponseType(typeof(ProductColor), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ProductColor Get_Color_By_Id(int id)
        {
            return service.Get_Color_By_id(id);
        }

        
        
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Color(int id)
        {
            return service.Delete_Color(id);
        }
    }
}
