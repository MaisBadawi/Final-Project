using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
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
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService productService;

        public PropertyController(IPropertyService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(List<GetPropertyDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetPropertyDto> GetAll_Property()
        { return productService.GetAll_Property(); }
     
        [HttpPost]
        [ProducesResponseType(typeof(List<GetPropertyDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetPropertyDto> GetProperty_IDProduct(Property proparty)
        { return productService.GetProperty_IDProduct(proparty); }

        [HttpPost]
        [Route("NewProperty")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Property([FromBody] Property proparty)
        { return productService.Insert_Property(proparty); }

        [HttpDelete]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Property(int id)
        { return productService.Delete_Property(id); }

        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Property([FromBody] Property proparty)
        { return productService.Update_Property(proparty); }

      
        
        [HttpPut]
        [Route ("UpdateQuantity/{id}/{quantity}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Quantity(int id, int quantity)
        { return productService.Update_Quantity(id,quantity); }

       
        
        [HttpGet]
        [Route("GetPropertyById/{id}")]
        [ProducesResponseType(typeof(GetPropertyDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public GetPropertyDto GetProperty_ID(int id)
        { return productService.GetProperty_ID(id); }



        [HttpGet]
        [Route("GetAvailabel")]
        [ProducesResponseType(typeof(List<GetPropertyDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetPropertyDto> GetAll_AvailabelProperty()
        { return productService.GetAll_AvailabelProperty(); }




        [HttpGet]
        [Route("GetByName/{name}")]
        [ProducesResponseType(typeof(List<GetPropertyDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetPropertyDto> GetByName(string name)
        {
            return productService.GetByName(name);
        }


        [HttpGet]
        [Route("GetNewest")]
        [ProducesResponseType(typeof(List<NewestProductDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<NewestProductDto> GetNewestProperty()
        {
            return productService.GetNewestProperty();
        }

        [HttpGet]
        [Route("Soldout")]
        [ProducesResponseType(typeof(List<GetPropertyDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetPropertyDto> GetSoldoutProperty()
        {
            return productService.GetSoldoutProperty();
        }

    }
}
