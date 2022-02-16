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
  public class AggregationRepository : IAggregationRepository
  {
    private readonly IdbContext context;
    public AggregationRepository(IdbContext context)
    {
      this.context = context;
    }
    public Aggregetion NumEmp()
    {

      var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumEmp", commandType: CommandType.StoredProcedure);
      return result.FirstOrDefault();
    }

    public Aggregetion NumUser()
    {


      var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumUser", commandType: CommandType.StoredProcedure);
      return result.FirstOrDefault();
    }

    public Aggregetion NumOfOrder(int IDOFUSER)
        {//int IDOFUSER
            var p = new DynamicParameters();
      p.Add("IDOFUSER", IDOFUSER, dbType: DbType.Int32, direction: ParameterDirection.Input);

      var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumOfOrder", p, commandType: CommandType.StoredProcedure);
      return result.FirstOrDefault();

    }

    public Aggregetion NumOrderDev(Order Id_dev)
    {
      var p = new DynamicParameters();
      p.Add("Id_dev", Id_dev.DeliveryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

      var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumOrderDev", p, commandType: CommandType.StoredProcedure);
      return result.FirstOrDefault();
    }

    public Aggregetion NumOrderDevDaily(OrderDev orderDev)
    {
      var p = new DynamicParameters();
      p.Add("Id_dev", orderDev.Id_dev, dbType: DbType.Int32, direction: ParameterDirection.Input);
      p.Add("dateday", orderDev.Dateday, dbType: DbType.DateTime, direction: ParameterDirection.Input);

      var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumOrderDevDaily", p, commandType: CommandType.StoredProcedure);
      return result.FirstOrDefault();
    }

   

    public Aggregetion SumOrders(int IDOFUSER)
        {//int IDOFUSER
            var p = new DynamicParameters();
            p.Add("IDOFUSER",IDOFUSER, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.SumOrders", p, commandType: CommandType.StoredProcedure);
             return result.FirstOrDefault();
    }

    public Aggregetion SumSalary()
        {
            //Query<Aggregetion>

            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.SumSalary", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
    }

    public Aggregetion SumSales()
        {
            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.SumSales",  commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

    public Aggregetion SumSalesDaily()
    {
     

      var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.SumSalesDaily", commandType: CommandType.StoredProcedure);
      return result.FirstOrDefault();
    }

        public Aggregetion NumberOfCard(int IDOFUSER)
        {
            var p = new DynamicParameters();
            p.Add("IDOFUSER", IDOFUSER, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumOfCards", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Aggregetion MyMssg(int IDOFUSER)
        {
            var p = new DynamicParameters();
            p.Add("IDOFUSER", IDOFUSER, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.UserMessage", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }


        public Aggregetion SalesMonthly(Aggregetion ag)
        {
            var p = new DynamicParameters();
            p.Add("A_year", ag.A_year, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("A_month", ag.A_month, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.SalesMonthly", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Aggregetion SalesYearly(Aggregetion ag)
        {
            var p = new DynamicParameters();
            p.Add("A_year", ag.A_year, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.SalesYearly", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Aggregetion NumOrdersDaily()
        {

            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumOrdersDaily", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Aggregetion NumAllProductCurrently()
        {

            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumAllProductCurrently", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Aggregetion NumProductsSoldDaily()
        {
            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumProductsSoldDaily", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Aggregetion NumProductsSoldMonthly()
        {
            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumProductsSoldMonthly", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Aggregetion NumProductsSoldYearly()
        {
            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumProductsSoldYearly", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Aggregetion NumProductsSoldBetweenDates(DateTime DateFrom, DateTime DateTo)
        {
            var p = new DynamicParameters();
            p.Add("DateFrom", DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("DateTo", DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumProductsSoldBetweenDates", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Aggregetion NumSMSNew()
        {
            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.NumSMSNew", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

       

        public Aggregetion SumSalAfterDed()
        {
            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.SumSalAfterDed", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

       



    }
}
