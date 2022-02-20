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
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService service;
        public ReviewController(IReviewService service)
        {
            this.service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Review(Reviews review)
        {
            return service.Insert_Review(review);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Review(int id)
        {
            return service.Delete_Review(id);
        }

        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Review(Reviews review)
        {
            return service.Update_Review(review);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<AllReviewDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<AllReviewDto> GET_All_Review()
        {
            return service.GET_All_Review();
        }

        [HttpGet]
        [Route ("GetReviewById/{id}")]
        [ProducesResponseType(typeof(AllReviewDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public AllReviewDto Get_Review_By_Id(int id)
        {
            return service.Get_Review_By_Id(id);
        }

        [HttpGet]
        [Route("GetReviewByIdProduct/{id}")]
        [ProducesResponseType(typeof(AllReviewDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public AllReviewDto Get_Review_By_IdProduct(int id)
        {
            return service.Get_Review_By_IdProduct(id);
        }

        [HttpGet]
        [Route("TopRating")]
        [ProducesResponseType(typeof(List<TopRatingDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<TopRatingDto> Top_Rating()
        {
            return service.Top_Rating();
        }

        [HttpGet]
        [Route("AllRating")]
        [ProducesResponseType(typeof(TopRatingDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<TopRatingDto> All_Rating()
        {
            return service.All_Rating();
        }


    }
}
