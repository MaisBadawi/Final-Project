using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
    public class Employee
    {

        public decimal? Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }

        public string EmpImage { get; set; }
        public decimal? Salary { get; set; }
        public decimal? DEDUCTION { get; set; }

        public decimal Gender { get; set; }
        public string USERNAME { get; set; }


    }
}
