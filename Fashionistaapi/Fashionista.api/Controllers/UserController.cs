using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashionista.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpDelete]
        [Route("DeleteUser/{Id}")]

        public bool DELETEUSER(int Id)
        {
            return userService.DELETEUSER(Id);
        }

        [HttpPost]
        [Route("AddUser")]
        public bool INSERTUSER(User user)
        {
            return userService.INSERTUSER(user);
        }

        [HttpPost]
        [Route("UpdateUser")]
        public bool UPDATEUSER(User user)
        {
            return userService.UPDATEUSER(user);
        }

        [HttpGet]
        [Route("AllCustomer")]
        public List<Customer> GetAllCustomer()
        {
            return userService.GetAllCustomer();
        }

        [HttpGet]
        [Route("AllEmployee")]
        public List<Employee> GetAllEmployee()
        {
            return userService.GetAllEmployee();
        }

        [HttpGet]
        [Route("CustomerByName/{CustName}")]
        public List<Customer> SearchCustomerByName(string CustName)
        {
            return userService.SearchCustomerByName(CustName);

        }

        [HttpGet]
        [Route("EmployeeByName/{EmpName}")]
        public List<Employee> SearchEmployeeBYName(string EmpName)
        {
            return userService.SearchEmployeeBYName(EmpName);

        }

        [HttpPost]
        [Route("changepass")]
        public string ChangePass([FromBody] Auth auth)
        {
            var item = userService.Changepass(auth);
            if (item == true)
            {
                return "Your new password has been sent to your email";
            }
            else
            {
                return "The username is not available";
            }

        }


        [HttpPost]
        [Route("Check")]
        public string Check_Username([FromBody] Auth auth)
        {
            var item = userService.Check_Username(auth);
            if (item == true)
            {
                return "The username is already exist";
            }
            else
            {
                return "The username is not available";
            }

        }




    }
}
