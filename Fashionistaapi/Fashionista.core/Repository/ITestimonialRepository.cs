using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
    public interface ITestimonialRepository
    {
        public string Insert_Testimonial(Testimonial testamonial);
        public bool Delete_Testimonial(int id);
        public bool Update_Testimonial(Testimonial testamonial);
        public List<GetAllTestamonialDto> GET_All_TestimonialForAdmin();
        public List<GetAllTestamonialDto> GET_All_TestimonialForCustm();
        public Testimonial Get_Testimonial_By_Id(int id);
    }
}
