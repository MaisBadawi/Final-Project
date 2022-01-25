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
    public class ReviewRrepository : IReviewRrepository
    {
        private readonly IdbContext context;
        public ReviewRrepository(IdbContext context)
        {
            this.context = context;
        }

        public bool Delete_Review(int id)
        {
            var p = new DynamicParameters();
            p.Add("R_Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Reviews_Package.Delete_Review", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<AllReviewDto> GET_All_Review()
        {
            IEnumerable<AllReviewDto> result = context.connection.Query<AllReviewDto>("Reviews_Package.Get_All_Review", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public AllReviewDto Get_Review_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("R_Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<AllReviewDto>("Reviews_Package.Get_All_Review_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }

        public AllReviewDto Get_Review_By_IdProduct(int id)//
        {
            var p = new DynamicParameters();
            p.Add("R_Product_Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<AllReviewDto>("Reviews_Package.Get_Review_By_IdProduct", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public string Insert_Review(Reviews review)
        {
            var p = new DynamicParameters();

            p.Add("R_Comment", review.COMMENTS, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("R_Cust_Id", review.CUSTOMER_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("R_Product_Id", review.PRODUCT_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("R_Status", review.STATUS, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Reviews_Package.Insert_Review", p, commandType: CommandType.StoredProcedure);
            return "true";
        }

        public TopRatingDto Top_Rating()
        {
            var result = context.connection.Query<TopRatingDto>("Reviews_Package.Top_Rating",  commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool Update_Review(Reviews review)
        {
            var p = new DynamicParameters();
            p.Add("R_Id",review.ID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("R_Comment", review.COMMENTS, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("R_Cust_Id", review.CUSTOMER_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("R_Product_Id", review.PRODUCT_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("R_Status", review.STATUS, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Reviews_Package.Update_Review", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
