﻿using Fashionista.core.Data;
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
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DELETEUSER(int Id)
        {
            return userService.DELETEUSER(Id);
        }

        [HttpPost]
        [Route("AddUser")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool INSERTUSER(User user)
        {
            return userService.INSERTUSER(user);
        }

        [HttpPost]
        [Route("UpdateUser")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UPDATEUSER(User user)
        {
            return userService.UPDATEUSER(user);
        }


        [HttpGet]
        [Route("AllCustomer")]
        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Customer> GetAllCustomer()
        {
            return userService.GetAllCustomer();
        }


        [HttpGet]
        [Route("AllEmployee")]
        [ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Employee> GetAllEmployee()
        {
            return userService.GetAllEmployee();
        }

        [HttpGet]
        [Route("CustomerByName/{CustName}")]
        [ProducesResponseType(typeof(List<Customer>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Customer> SearchCustomerByName(string CustName)
        {
            return userService.SearchCustomerByName(CustName);

        }


        [HttpGet]
        [Route("EmployeeByName/{EmpName}")]
        [ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Employee> SearchEmployeeBYName(string EmpName)
        {
            return userService.SearchEmployeeBYName(EmpName);

        }


        [HttpPost]
        [Route("changepass")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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



        [HttpPost]
        [Route("Auth")]
     
        public IActionResult Auth([FromBody] User user)
        {
            var item =userService.Auth(user);
            if (item == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(item);
            }


        }



    }
}
