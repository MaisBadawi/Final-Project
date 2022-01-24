﻿using Dapper;
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
    public class PropertyRepository : IPropertyRepository
    {
        private readonly IdbContext context;

        public PropertyRepository (IdbContext dbcontext)
        {
            context = dbcontext;
        }

        public bool Delete_Property(int id)
        {
            var p = new DynamicParameters();
            p.Add("P_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var item = context.connection.ExecuteAsync("Proparety_Package.Delete_Property", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<GetPropertyDto> GetAll_Property()
        {
            IEnumerable<GetPropertyDto> result = context.connection.Query<GetPropertyDto>("Proparety_Package.GetAll_Property", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public GetPropertyDto GetProperty_ID(int id)
        {
            var p = new DynamicParameters();
            p.Add("P_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<GetPropertyDto>("Proparety_Package.GetProperty_ID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public List<GetPropertyDto> GetProperty_IDProduct(Property proparty)
        {
            var p = new DynamicParameters();
            p.Add("@P_PrpductId", proparty.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Skin_Color", proparty.SkinId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@P_SizeGeneral", proparty.SizeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@P_AgePeriod", proparty.AgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<GetPropertyDto>("Proparety_Package.GetProperty_IDProduct", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string Insert_Property(Property proparty)
        {
            var p = new DynamicParameters();

            p.Add("@P_Quantity", proparty.Quantite, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@P_Color_Id", proparty.ColorId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@P_Size_Id ", proparty.SizeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@P_PrpductId", proparty.ProductId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@P_SkinId", proparty.SkinId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_AgeId", proparty.AgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            var result = context.connection.ExecuteAsync("Proparety_Package.Insert_Property", p, commandType: CommandType.StoredProcedure);


            return "Valid";
        }

        public bool Update_Property(Property proparty)
        {
            var p = new DynamicParameters();

            p.Add("P_ID", proparty.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_Quantity", proparty.Quantite, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_Color_Id", proparty.ColorId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_Size_Id ", proparty.SizeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_PrpductId", proparty.ProductId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_SkinId", proparty.SkinId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_AgeId", proparty.AgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("Proparety_Package.Update_Property", p, commandType: CommandType.StoredProcedure);


            return true;
        }

        public bool Update_Quantity(int id, int quantity)
        {
            var p = new DynamicParameters();
            p.Add("P_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("P_Quantity", quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Proparety_Package.Update_Quantity", p, commandType: CommandType.StoredProcedure);


            return true;
        }

        
    }
}