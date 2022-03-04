using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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

        [HttpGet]
        [ProducesResponseType(typeof(List<ProductDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("GetProductByCategory/{id}")]
        public List<ProductDto> GetProduct_byCategory(int id)
        {
            return catservice.GetProduct_byCategory(id);
        }


        [HttpPost]
        [Route("uploadimage")]
        public Category UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                byte[] fileImageContent;
                using (var memory = new MemoryStream())
                {
                    file.CopyTo(memory);
                    fileImageContent = memory.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string imageFileName = $"{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";

                string path = Path.Combine("C:\\Users\\iMSI\\Desktop\\Team\\Fashinista (2)\\Fashinista\\Fashion\\Task\\src\\assets\\image", imageFileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return new Category()
                {
                    Image_Path = imageFileName
                };
            }
            catch (FileLoadException)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("updateimage")]
        public Category updateimage()
        {
            try
            {
                var file = Request.Form.Files[0];
                byte[] fileImageContent;
                using (var memory = new MemoryStream())
                {
                    file.CopyTo(memory);
                    fileImageContent = memory.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string imageFileName = $"{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";

                string path = Path.Combine("C:\\Users\\iMSI\\Desktop\\Team\\Fashinista (2)\\Fashinista\\Fashion\\Task\\src\\assets\\image", imageFileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return new Category()
                {
                    Image_Path = imageFileName
                };
            }
            catch (FileLoadException)
            {
                return null;
            }
        }

    }
}
