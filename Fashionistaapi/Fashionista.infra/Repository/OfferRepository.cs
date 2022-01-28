using Dapper;
using Fashionista.core.Common;
using Fashionista.core.Data;
using Fashionista.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fashionista.infra.Repository
{
    public class OfferRepository : IOfferRepository
    {
        private readonly IdbContext context;
        public OfferRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool Delete_Offer(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Offer", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("Offer_Package.Delete_Offer", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Offer> GET_All_Offer()
        {
            IEnumerable<Offer> result = context.connection.Query<Offer>("Offer_Package.Get_All_Offer", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Offer Get_Offer_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Offer", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Offer>("Offer_Package.Get_Offer_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public string Insert_Offer(Offer offer)
        {
            var p = new DynamicParameters();

            p.Add("Offer_Amount", offer.Amount, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("FromDate", offer.FromDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("ToDate", offer.ToDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Offer_Package.Insert_Offer", p, commandType: CommandType.StoredProcedure);
            return "valid";
        }

        public bool Update_Offer(Offer offer)
        {
            var p = new DynamicParameters();

            p.Add("Id_Offer", offer.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Offer_Amount", offer.Amount, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("FromDate", offer.FromDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("ToDate", offer.ToDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            var result = context.connection.ExecuteAsync("Offer_Package.Update_Offer", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
