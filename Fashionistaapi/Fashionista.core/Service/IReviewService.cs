using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
   public interface IReviewService
    {
        public string Insert_Review(Reviews review);
        public bool Delete_Review(int id);
        public bool Update_Review(Reviews review);
        public List<AllReviewDto> GET_All_Review();
        public AllReviewDto Get_Review_By_Id(int id);


        public AllReviewDto Get_Review_By_IdProduct(int id);
        public List<TopRatingDto> Top_Rating();
        public List<TopRatingDto> All_Rating();
    }
}
