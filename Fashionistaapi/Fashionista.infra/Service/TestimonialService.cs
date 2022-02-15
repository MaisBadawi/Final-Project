using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository testimonialRepository;
        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            this.testimonialRepository = testimonialRepository;
        }

        public bool AcceptTestimonial(int id)
        {
            return testimonialRepository.AcceptTestimonial(id);
        }

        public List<GetAllTestamonialDto> AllAcceptTestimonial()
        {
            return testimonialRepository.AllAcceptTestimonial();
        }

        public List<GetAllTestamonialDto> AllRejectTestimonial()
        {
            return testimonialRepository.AllRejectTestimonial();
        }

        public bool Delete_Testimonial(int id)
        {
            return testimonialRepository.Delete_Testimonial(id);
        }

        public List<GetAllTestamonialDto> GET_All_TestimonialForAdmin()
        {
            return testimonialRepository.GET_All_TestimonialForAdmin();
        }

        public List<GetAllTestamonialDto> GET_All_TestimonialForCustm()
        {
            return testimonialRepository.GET_All_TestimonialForCustm();
        }

        public Testimonial Get_Testimonial_By_Id(int id)
        {
            return testimonialRepository.Get_Testimonial_By_Id(id);
        }

        public string Insert_Testimonial(Testimonial testamonial)
        {
            return testimonialRepository.Insert_Testimonial(testamonial);
        }

        public bool RejectTestimonial(int id)
        {
            return testimonialRepository.RejectTestimonial(id);
         }

        public bool Update_Testimonial(Testimonial testamonial)
        {
            return testimonialRepository.Update_Testimonial(testamonial);
        }
    }
}
