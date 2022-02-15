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
    public class UserRepository : IUserRepository
    {
        private readonly IdbContext context;
        public UserRepository(IdbContext context)
        {
            this.context = context;
        }

        public User Auth(User user)
        {
            var ob = new DynamicParameters();
            ob.Add("PASS", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("U_USERNAME", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<User> result = context.connection.Query<User>("USERS_PACKAGE.User_Login", ob, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public User Changepass(Auth auth)
        {
            var ob1 = new DynamicParameters();
            ob1.Add("U_USERNAME", auth.U_USERNAME, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<User> result = context.connection.Query<User>("USERS_PACKAGE.Changepass", ob1, commandType: CommandType.StoredProcedure);
            var user = result.FirstOrDefault();

            if (user != null)
            {
                string pass = Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("+", string.Empty).Substring(0, 6);
                var ob = new DynamicParameters();

                ob.Add("IDOFUSER", user.Id, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                ob.Add("FNAMEOFUSER", user.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("LNAMEOFUSER", user.Lname, dbType: DbType.String, direction: ParameterDirection.Input);

                ob.Add("EMAILOFUSER", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("PHONEOFUSER", user.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("ADDRESSOFUSER", user.Address, dbType: DbType.String, direction: ParameterDirection.Input);

                ob.Add("IMAGE_PATHOFUSER",user.Image_Path, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("GENDEROFUSER", user.Gender, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                ob.Add("DATE_REGOFUSER", user.DateReg, dbType: DbType.DateTime, direction: ParameterDirection.Input);

                ob.Add("U_ROLE_ID",user.Rol_Id, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                ob.Add("U_Password",pass, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("U_username", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);

                ob.Add("UAge", user.Age, dbType: DbType.Decimal, direction: ParameterDirection.Input);

                ob.Add("SALARYOFUSER", user.Salary, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                ob.Add("HEIGHTOFUSER", user.Height, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                ob.Add("WEIGHTOFUSER", user.Weight, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                ob.Add("U_LX", user.Lx, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("U_LY", user.Ly, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("COLOROFUSER", user.SkinColor, dbType: DbType.String, direction: ParameterDirection.Input);

                context.connection.Execute("USERS_PACKAGE.UPDATEUSER", ob, commandType: CommandType.StoredProcedure);
                var ob2 = new DynamicParameters();
                decimal id = user.Id;
                ob2.Add("IDOFUSER", id, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                IEnumerable<User> result2 = context.connection.Query<User>("USERS_PACKAGE.GETUSERBYID", ob2, commandType: CommandType.StoredProcedure);
                return result2.SingleOrDefault();
            }
            else
            {
                return (user);
            }
        }

        public User Check_Username(Auth auth)
        {
                var ob = new DynamicParameters();

                ob.Add("U_USERNAME", auth.U_USERNAME, dbType: DbType.String, direction: ParameterDirection.Input);
                IEnumerable<User> result = context.connection.Query<User>("USERS_PACKAGE.Check_Username", ob, commandType: CommandType.StoredProcedure);
                return result.FirstOrDefault();
            
        }

        public bool DELETEUSER(int Id)
        {
            var ob = new DynamicParameters();
            ob.Add("IDOFUSER", Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            context.connection.Execute("USERS_PACKAGE.DELETEUSER", ob, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Customer> GetAllCustomer()
        {
            IEnumerable<Customer> result = context.connection.Query<Customer>("USERS_PACKAGE.GetAllCustomer", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Employee> GetAllEmployee()
        {
            IEnumerable<Employee> result = context.connection.Query<Employee>("USERS_PACKAGE.GetAllEmployee", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool INSERTUSER(User user)
        {
            var ob = new DynamicParameters();
   
            ob.Add("FNAMEOFUSER", user.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("LNAMEOFUSER", user.Lname, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("EMAILOFUSER", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("PHONEOFUSER", user.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("ADDRESSOFUSER", user.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("IMAGE_PATHOFUSER", user.Image_Path, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("GENDEROFUSER", user.Gender, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("DATE_REGOFUSER", user.DateReg, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            ob.Add("U_ROLE_ID", user.Rol_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            ob.Add("U_Password", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("U_username", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);

            if(user.Rol_Id==6)
            {
                ob.Add("UAge", user.Age, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                ob.Add("COLOROFUSER", user.SkinColor, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("SALARYOFUSER", null, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                ob.Add("HEIGHTOFUSER", user.Height, dbType: DbType.Int32, direction: ParameterDirection.Input);
                ob.Add("WEIGHTOFUSER", user.Weight, dbType: DbType.Int32, direction: ParameterDirection.Input);
                ob.Add("U_LX", user.Lx, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("U_LY", user.Ly, dbType: DbType.String, direction: ParameterDirection.Input);
            }
            else
            {
                ob.Add("COLOROFUSER", null, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("SALARYOFUSER", user.Salary, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                ob.Add("deductuinvalue", user.DEDUCTION, dbType: DbType.Decimal, direction: ParameterDirection.Input);

                ob.Add("HEIGHTOFUSER", null, dbType: DbType.Int32, direction: ParameterDirection.Input);
                ob.Add("WEIGHTOFUSER", null, dbType: DbType.Int32, direction: ParameterDirection.Input);
                ob.Add("U_LX", null, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("U_LY", null, dbType: DbType.String, direction: ParameterDirection.Input);
                ob.Add("UAge", null, dbType: DbType.Decimal, direction: ParameterDirection.Input);

            }

            context.connection.Execute("USERS_PACKAGE.INSERTUSER", ob, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Customer> SearchCustomerByName(string CustName)
        {
            var p = new DynamicParameters();
            p.Add("CustName", CustName, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<Customer> result = context.connection.Query<Customer>("USERS_PACKAGE.SearchCustomerByName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Employee> SearchEmployeeBYName(string EmpName)
        {
            var p = new DynamicParameters();
            p.Add("EmpName", EmpName, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<Employee> result = context.connection.Query<Employee>("USERS_PACKAGE.SearchEmployeeBYName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UPDATEUSER(User user)
        {
            var ob = new DynamicParameters();

            ob.Add("IDOFUSER", user.Id, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            ob.Add("FNAMEOFUSER", user.Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("LNAMEOFUSER", user.Lname, dbType: DbType.String, direction: ParameterDirection.Input);

            ob.Add("EMAILOFUSER", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("PHONEOFUSER", user.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("ADDRESSOFUSER", user.Address, dbType: DbType.String, direction: ParameterDirection.Input);

            ob.Add("IMAGE_PATHOFUSER", user.Image_Path, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("GENDEROFUSER", user.Gender, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            ob.Add("DATE_REGOFUSER", user.DateReg, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            ob.Add("U_ROLE_ID", user.Rol_Id, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            ob.Add("U_Password", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("U_username", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);

            ob.Add("UAge", user.Age, dbType: DbType.Decimal, direction: ParameterDirection.Input);

            ob.Add("SALARYOFUSER", user.Salary, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            ob.Add("deductuinvalue", user.DEDUCTION, dbType: DbType.Decimal, direction: ParameterDirection.Input);

            ob.Add("HEIGHTOFUSER", user.Height, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            ob.Add("WEIGHTOFUSER", user.Weight, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            ob.Add("U_LX", user.Lx, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("U_LY", user.Ly, dbType: DbType.String, direction: ParameterDirection.Input);
            ob.Add("COLOROFUSER", user.SkinColor, dbType: DbType.String, direction: ParameterDirection.Input);


            context.connection.Execute("USERS_PACKAGE.UPDATEUSER", ob, commandType: CommandType.StoredProcedure);
            
            return true;

        }


        public User GetCustomerById(int id)
        {
            var p = new DynamicParameters();
            p.Add("IDOFUSER", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<User>("USERS_PACKAGE.GETUSERBYID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }

        public Employee GetEmployeeById(int id)
        {
            var p = new DynamicParameters();
            p.Add("P_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Employee>("USERS_PACKAGE.GetEmployeeById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
