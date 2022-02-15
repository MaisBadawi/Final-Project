using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
   public interface ITestimonialService
    {
        public string Insert_Testimonial(Testimonial testamonial);
        public bool Delete_Testimonial(int id);
        public bool Update_Testimonial(Testimonial testamonial);
        public List<GetAllTestamonialDto> GET_All_TestimonialForAdmin();
        public List<GetAllTestamonialDto> GET_All_TestimonialForCustm();
        public Testimonial Get_Testimonial_By_Id(int id);

        public bool AcceptTestimonial(int id);
        public bool RejectTestimonial(int id);

        public List<GetAllTestamonialDto> AllAcceptTestimonial();
        public List<GetAllTestamonialDto> AllRejectTestimonial();
    }
}
