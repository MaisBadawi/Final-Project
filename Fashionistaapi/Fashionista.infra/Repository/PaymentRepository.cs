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
    public class PaymentRepository : IPaymentRepository
    {
        private readonly IdbContext context;

        public PaymentRepository(IdbContext dbcontext)
        {
            this.context = dbcontext;
        }
        public bool Delete_Visa_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Visa", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

             context.connection.ExecuteAsync("Payment_Package.Delete_Visa_By_Id", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool Discount_Order(int userId,decimal orderPrice)
        {
            var p = new DynamicParameters();

            
            p.Add("UserId",userId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Order_Price", orderPrice, dbType: DbType.Int32, direction: ParameterDirection.Input);


             context.connection.ExecuteAsync("Payment_Package.Discount_Order", p, commandType: CommandType.StoredProcedure);


            return true;
        }

        public List<Payment> Get_All_Visa()
        {
            IEnumerable<Payment> result = context.connection.Query<Payment>("Payment_Package.Get_All_Visa", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public Payment Get_Balance(int userId)
        {
            var p = new DynamicParameters();
            p.Add("UserId", userId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            Payment result = context.connection.Query<Payment>("Payment_Package.Get_Balance", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return result;
        }

        public Payment Get_Visa_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Visa", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.Query<Payment>("Payment_Package.Get_Visa_By_Id", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

    public Payment Get_Visa_By_UserId(int User_Id)
    {
      var p = new DynamicParameters();
      p.Add("UserId", User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

      var result = context.connection.Query<Payment>("Payment_Package.Get_Visa_By_UserId", p, commandType: CommandType.StoredProcedure);
      return result.FirstOrDefault();
    }

    public string Insert_Visa(Payment payment)
        {
            var p = new DynamicParameters();

            p.Add("VisaNumber", payment.Visa_Number, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Pass", payment.Cvv, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Visa_Balance", payment.Balanc, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("UserId", payment.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ExpDate", payment.Experd_Date, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("UpdateCodeU", payment.UpdateCode, dbType: DbType.String, direction: ParameterDirection.Input);

             context.connection.ExecuteAsync("Payment_Package.Insert_Visa", p, commandType: CommandType.StoredProcedure);


            return "Valid";
        }

        public BalanceDto SUM_Max_Balance()
        {

            var result = context.connection.Query<BalanceDto>("Payment_Package.SUM_Max_Balance", commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

    public bool UpdateBalance(UpdateBalance updateBalance)
    {
      var p = new DynamicParameters();
     
     
      p.Add("Visa_Balance",updateBalance.Visa_Balance, dbType: DbType.Decimal, direction: ParameterDirection.Input);
      p.Add("UserId", updateBalance.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
     


      context.connection.ExecuteAsync("Payment_Package.Update_Balance", p, commandType: CommandType.StoredProcedure);


      return true;
    }

    public UpdateCode Update_Code(int userId)
    {
      var ob1 = new DynamicParameters();
      ob1.Add("IDOFUSER", userId, dbType: DbType.String, direction: ParameterDirection.Input);
      IEnumerable<User> result = context.connection.Query<User>("USERS_PACKAGE.GETUSERBYID", ob1, commandType: CommandType.StoredProcedure);
      var user = result.FirstOrDefault();

      UpdateCode u = new UpdateCode();
      u.EmailU = user.Email;
      u.Code= Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("+", string.Empty).Substring(0, 6);
      return u;
    }

    public bool Update_Visa_By_Id(Payment payment)
        {
            var p = new DynamicParameters();
            p.Add("Id_Of_Visa", payment.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("VisaNumber", payment.Visa_Number, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Pass", payment.Cvv, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Visa_Balance", payment.Balanc, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("UserId", payment.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ExpDate", payment.Experd_Date, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("UpdateCodeU", payment.UpdateCode, dbType: DbType.String, direction: ParameterDirection.Input);


      context.connection.ExecuteAsync("Payment_Package.Update_Visa_By_Id", p, commandType: CommandType.StoredProcedure);


            return true;
        }
    }
}
