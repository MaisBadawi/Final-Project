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
   public class ProductRepository : IProductRepository
    {
        private readonly IdbContext context;

        public ProductRepository(IdbContext dbcontext)
        {
            this.context = dbcontext;
        }

        public string Insert_Product(Product product)
        {
            var p = new DynamicParameters();

            p.Add("P_Name", product.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("P_Description", product.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("P_Price", product.Price, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("P_Image", product.IMAGE_PATH, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("P_OfferId", product.OFFER_ID, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("P_CategoryId", product.Category_Id, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("P_DateOfAdd", product.Dateofadd, dbType: DbType.Date, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Product_Package.Insert_Product", p, commandType: CommandType.StoredProcedure);


            return "Valid";
        }

        public bool Delete_Product(int id)
        {
            var p = new DynamicParameters();
            p.Add("P_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var item = context.connection.ExecuteAsync("Product_Package.Delete_Product", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool Update_Product(Product product)
        {
            var p = new DynamicParameters();

            p.Add("P_ID", product.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("P_Name", product.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("P_Description", product.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("P_Price", product.Price, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("P_Image", product.IMAGE_PATH, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("P_OfferId", product.OFFER_ID, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("P_CategoryId", product.Category_Id, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("P_DateOfAdd", product.Dateofadd, dbType: DbType.Date, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Product_Package.Update_Product", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<ProductDto> GetAll_Product()
        {
            IEnumerable<ProductDto> result = context.connection.Query<ProductDto>("Product_Package.GetAll_Product", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public Product GetProduct_ID(int id)
        {
            var p = new DynamicParameters();
            p.Add("P_ID",id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<Product>("Product_Package.GetProduct_ID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }


        public List<GetProductByInfo> GetProduct_Category(PersonInfoDto product)
        {
            var p = new DynamicParameters();

            p.Add("Skin_Color", product.SkinId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("height", product.Height, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("weight", product.Weight, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_AgePeriod", product.AgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_CategoryId", product.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<GetProductByInfo>("Product_Package.GetProduct_Category", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<GetProductByInfo> GetProduct_OrderDes(PersonInfoDto product)
        {
            var p = new DynamicParameters();

            p.Add("Skin_Color", product.SkinId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("height", product.Height, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("weight", product.Weight, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_AgePeriod", product.AgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_CategoryId", product.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<GetProductByInfo>("Product_Package.GetProduct_OrderDes", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<GetProductByInfo> GetProduct_OrderAsc(PersonInfoDto product)
        {
            var p = new DynamicParameters();

            p.Add("Skin_Color", product.SkinId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("height", product.Height, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("weight", product.Weight, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_AgePeriod", product.AgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_CategoryId", product.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<GetProductByInfo>("Product_Package.GetProduct_OrderAsc", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<GetProductByInfo> GetLatest_Product(PersonInfoDto product)
        {
            var p = new DynamicParameters();

            p.Add("Skin_Color", product.SkinId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("height", product.Height, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("weight", product.Weight, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_AgePeriod", product.AgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_CategoryId", product.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<GetProductByInfo>("Product_Package.GetLatest_Product", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<GetProductByInfo> GetProduct_Offer(PersonInfoDto product)
        {
            var p = new DynamicParameters();

            p.Add("Skin_Color", product.SkinId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("height", product.Height, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("weight", product.Weight, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_AgePeriod", product.AgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_CategoryId", product.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<GetProductByInfo>("Product_Package.GetProduct_Offer", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


    }
}
