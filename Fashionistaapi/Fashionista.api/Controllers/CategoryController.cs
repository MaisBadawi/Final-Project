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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService catservice;
        public CategoryController(ICategoryService catservice)
        {
            this.catservice = catservice;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Category([FromBody] Category cat)
        {
            return catservice.Insert_Category(cat);
        }
        
        
        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Category([FromBody] Category cat)
        {
            return catservice.Update_Category(cat);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Category> GET_All_Category()
        {
            return catservice.Get_All_Category();
        }

       
        
        [HttpGet("GetCategoryById/{id}")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Category Get_Category_By_Id(int id)
        {
            return catservice.Get_Category_By_Id(id);
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Category_By_Id(int id)
        {
            return catservice.Delete_Category_By_Id(id);
        }
    }
}
