using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
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
        private readonly IPropertyRepository productService;

        public PropertyController(IPropertyRepository productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<GetPropertyDto> GetAll_Property()
        { return productService.GetAll_Property(); }
     
        [HttpPost]
        public List<GetPropertyDto> GetProperty_IDProduct(Property proparty)
        { return productService.GetProperty_IDProduct(proparty); }

        [HttpPost]
        [Route("NewProperty")]
        public string Insert_Property([FromBody] Property proparty)
        { return productService.Insert_Property(proparty); }

        [HttpDelete]
        public bool Delete_Property(int id)
        { return productService.Delete_Property(id); }

        [HttpPut]
        public bool Update_Property([FromBody] Property proparty)
        { return productService.Update_Property(proparty); }

        [HttpPut]
        [Route ("UpdateQuantity/{id}/{quantity}")]
        public bool Update_Quantity(int id, int quantity)
        { return productService.Update_Quantity(id,quantity); }

        [HttpGet]
        [Route("GetPropertyById/{id}")]
        public GetPropertyDto GetProperty_ID(int id)
        { return productService.GetProperty_ID(id); }

    }
}
