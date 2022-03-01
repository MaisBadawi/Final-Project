using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
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
        public List<GetPropertyDto> GetProperty_IDProduct(PersonInfoDto proparty)
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



        [HttpGet]
        [Route("GetPropDetails")]
        [ProducesResponseType(typeof(DetailsProp), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<DetailsProp> GetPropDetails()
        {
            return productService.GetPropDetails();
        }


        [HttpPost]
        [Route("GetPropDetailsBetweenDates")]
        [ProducesResponseType(typeof(DetailsProp), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<DetailsProp> GetPropDetailsBetweenDates(DateTime DateFrom, DateTime DateTo)
        {
            return productService.GetPropDetailsBetweenDates(DateFrom, DateTo);
        }

        [HttpGet]
        [Route("GetPropDetailsDaily")]
        [ProducesResponseType(typeof(DetailsProp), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<DetailsProp> GetPropDetailsDaily()
        {
            return productService.GetPropDetailsDaily();
        }

        [HttpGet]
        [Route("GetPropDetailsMonthly")]
        [ProducesResponseType(typeof(DetailsProp), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<DetailsProp> GetPropDetailsMonthly()
        {
            return productService.GetPropDetailsMonthly();
        }

        [HttpGet]
        [Route("GetPropDetailsYearly")]
        [ProducesResponseType(typeof(DetailsProp), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<DetailsProp> GetPropDetailsYearly()
        {
            return productService.GetPropDetailsYearly();
        }


        [HttpPost]
        [Route("uploadimage")]
        public Property UploadImage()
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

                string path = Path.Combine("C:\\Users\\Otaibah toppsh\\Desktop\\Final-project-master\\Final-project-master\\Fashion\\Task\\src\\assets\\image", imageFileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return new Property()
                {
                    ImageProp = imageFileName
                };
            }
            catch (FileLoadException)
            {
                return null;
            }
        }


        [HttpPut]
        [Route("updateImage")]
        public Property updateImage()
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

                string path = Path.Combine("C:\\Users\\Otaibah toppsh\\Desktop\\Final-project-master\\Final-project-master\\Fashion\\Task\\src\\assets\\image", imageFileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return new Property()
                {
                    ImageProp = imageFileName
                };
            }
            catch (FileLoadException)
            {
                return null;
            }
        }


    }
}
