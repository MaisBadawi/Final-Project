using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
    public interface IUserService
    {
        public bool INSERTUSER(User user);
        public bool DELETEUSER(int Id);
        public bool UPDATEUSER(User user);

        public List<Employee> GetAllEmployee();
        public Employee GetEmployeeById(int id);

        public List<Customer> GetAllCustomer();

        public List<Employee> SearchEmployeeBYName(string EmpName);
        public List<Customer> SearchCustomerByName(string CustName);
        public string Auth(User user);
        public bool Check_Username(Auth auth);
        public bool Changepass(Auth auth);

        public User GetCustomerById(int id);
    }
}
