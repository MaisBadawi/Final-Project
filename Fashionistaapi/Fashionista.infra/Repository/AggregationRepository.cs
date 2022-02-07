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

    public Aggregetion NumOfOrder(User IDOFUSER)
    {
      var p = new DynamicParameters();
      p.Add("IDOFUSER", IDOFUSER.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

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

   

    public Aggregetion SumOrders(User IDOFUSER)
        {
            var p = new DynamicParameters();
            p.Add("IDOFUSER",IDOFUSER.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.SumOrders", p, commandType: CommandType.StoredProcedure);
             return result.FirstOrDefault();
    }

    public Aggregetion SumSalary()
        {
       

            var result = context.connection.Query("Aggregation_PACKAGE.SumSalary", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
    }

    public Aggregetion SumSales()
        {
          

            var result = context.connection.Query("Aggregation_PACKAGE.SumSales",  commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
    }

    public Aggregetion SumSalesDaily(Aggregetion aggregetion)
    {
      var p = new DynamicParameters();
       p.Add("Datesales",aggregetion.dateDatesales, dbType: DbType.Date, direction: ParameterDirection.Input);

      var result = context.connection.Query<Aggregetion>("Aggregation_PACKAGE.SumSalesDaily", p, commandType: CommandType.StoredProcedure);
      return result.FirstOrDefault();
    }

  }
}