using Fashionista.core.Data;
using Fashionista.core.DTO;
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
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService service;
        public TestimonialController(ITestimonialService service)
        {
            this.service = service;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Testimonial(int id)
        {
            return service.Delete_Testimonial(id);
        }



        [HttpGet]
        [Route("GetAllTestimonialForAdmin")]
        [ProducesResponseType(typeof(List<GetAllTestamonialDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetAllTestamonialDto> GET_All_TestimonialForAdmin()
        {
            return service.GET_All_TestimonialForAdmin();
        }


        [HttpGet]
        [Route("GetAllTestimonialForCustm")]
        [ProducesResponseType(typeof(List<GetAllTestamonialDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetAllTestamonialDto> GET_All_TestimonialForCustm()
        {
            return service.GET_All_TestimonialForCustm();
        }

        [HttpGet]
        [Route("GetTestimonialById/{id}")]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Testimonial Get_Testimonial_By_Id(int id)
        {
            return service.Get_Testimonial_By_Id(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Testimonial(Testimonial testamonial)
        {
            return service.Insert_Testimonial(testamonial);
        }


        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Testimonial(Testimonial testamonial)
        {
            return service.Update_Testimonial(testamonial);
        }


        [HttpGet]
        [Route("AcceptTestimonial/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool AcceptTestimonial(int id)
        {
            return service.AcceptTestimonial(id);
        }


        [HttpGet]
        [Route("AllRejectTestimonial")]
        [ProducesResponseType(typeof(List<GetAllTestamonialDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetAllTestamonialDto> AllRejectTestimonial()
        {
            return service.AllRejectTestimonial();
        }


        [HttpGet]
        [Route("AllAcceptTestimonial")]
        [ProducesResponseType(typeof(List<GetAllTestamonialDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetAllTestamonialDto> AllAccepTestimonial()
        {
            return service.AllAcceptTestimonial();
        }

    }
}
