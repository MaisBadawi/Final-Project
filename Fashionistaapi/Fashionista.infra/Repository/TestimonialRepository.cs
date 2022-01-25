using Dapper;
using Fashionista.core.Common;
using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fashionista.infra.Repository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IdbContext context;
        public TestimonialRepository(IdbContext context)
        {
            this.context = context;
        }

        public bool Delete_Testimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("T_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("TESTIMONIALS_PACKAGE.DELETETESTIMONIALS", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<GetAllTestamonialDto> GET_All_TestimonialForAdmin()
        {
            IEnumerable<GetAllTestamonialDto> result = context.connection.Query<GetAllTestamonialDto>("TESTIMONIALS_PACKAGE.GETALLTESTIMONIALS_Admin", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<GetAllTestamonialDto> GET_All_TestimonialForCustm()
        {
            IEnumerable<GetAllTestamonialDto> result = context.connection.Query<GetAllTestamonialDto>("TESTIMONIALS_PACKAGE.GETALLTESTIMONIALS_User", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Testimonial Get_Testimonial_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("T_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Testimonial>("TESTIMONIALS_PACKAGE.GETTESTIMONIALSBYID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public string Insert_Testimonial(Testimonial testamonial)
        {
            var p = new DynamicParameters();
            p.Add("T_TEXET", testamonial.Id, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("T_STATUS", testamonial.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("T_CUSTOMER_ID", testamonial.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Execute("TESTIMONIALS_PACKAGE.INSERTTESTIMONIALS", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Testimonial(Testimonial testamonial)
        {
            var p = new DynamicParameters();

            p.Add("T_ID", testamonial.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("T_TEXET", testamonial.Texet, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("T_STATUS", testamonial.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("T_CUSTOMER_ID", testamonial.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("TESTIMONIALS_PACKAGE.UPDATETESTIMONIALS", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
