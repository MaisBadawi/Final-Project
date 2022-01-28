using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRrepository reviewRepository;
        public ReviewService(IReviewRrepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }

        public bool Delete_Review(int id)
        {
            return reviewRepository.Delete_Review(id);
        }

        public List<AllReviewDto> GET_All_Review()
        {
            return reviewRepository.GET_All_Review();
        }

        public AllReviewDto Get_Review_By_Id(int id)
        {
            return reviewRepository.Get_Review_By_Id(id);
        }

        public AllReviewDto Get_Review_By_IdProduct(int id)
        {
            return reviewRepository.Get_Review_By_IdProduct(id);        }

        public string Insert_Review(Reviews review)
        {
            return reviewRepository.Insert_Review(review);
        }

        public TopRatingDto Top_Rating()
        {
            return reviewRepository.Top_Rating();
        }

        public bool Update_Review(Reviews review)
        {
            return reviewRepository.Update_Review(review);
        }
    }
}
