using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
    public interface IUserRepository
    {
        public bool INSERTUSER(User user);
        public bool DELETEUSER(int Id);
        public bool UPDATEUSER(User user);

        public List<Employee> GetAllEmployee();
        public List<Customer> GetAllCustomer();

        public List<Employee> SearchEmployeeBYName(string EmpName );
        public  List<Customer> SearchCustomerByName( string CustName );
      
        public User Check_Username(Auth auth);
        public User Changepass(Auth auth);
        public User Auth(User user);

        public User GetCustomerById(int id);


    }
}
